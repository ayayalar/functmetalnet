using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctMetaL.Core;
using System.IO;
using System.Diagnostics;
using FunctMetaL.Util;

namespace TestFunctMetaL
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestFunctMetaL
    {
        public TestFunctMetaL()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext) 
        {
            FunctMetaL.Core.Main.Log = true;
        }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize() 
        {
            FunctMetaL.Core.Main.Log = true;
        }
        //
        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup() 
        {
            FunctMetaL.Util.Logger.Clear();
        }
        //
        #endregion

        [TestMethod]
        public void Test_Core_IfElse()
        {            
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();
            
            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='1' />
                        <Variable name='y' value='2' />
                        <If test='$(x) -lt $(y)'>
                          <Message text='x less than y' />
                        </If>
                        <Else>
                          <Message text='y less than x' />
                        </Else>
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("x less than y"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_Switch()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='1' />
                        <Switch condition='$(x)'>
                          <Case condition='1'>
                             <Message text= 'case 1 matched.' />
                          </Case>
                          <Case condition='2'>
                             <Message text= 'case 2 matched.' />
                          </Case>
                          <Case condition='3'>
                             <Message text= 'case 3 matched.' />
                          </Case>
                        </Switch>
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("case 1 matched."),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_For_Loop()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='0' />
                        <Variable name='y' value='9' />
                        <For from='$(x)' to='$(y)'>
                          <Message text='-' />
                        </For>
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            StringBuilder sb = new StringBuilder();
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            sb.Append("-");
            
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains(sb.ToString()),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_ForEach()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='0' />
                        <Array name='arr2'>
                          <Item>1</Item>
                          <Item>2</Item>
                          <Item>3</Item>
                        </Array>
                        <ForEach array='arr2'>
                            <Message text='@(arr2[$(x)])' />
                            <Eval variable='$(x)' expression='++' />
                        </ForEach>
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            StringBuilder sb = new StringBuilder();
            sb.Append("1").Append("\r\n").Append("2").Append("\r\n").Append("3");
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains(sb.ToString()),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Util_Process()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();

            
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Process name='ipconfig' output='ipconfig_out' error='ipconfig_err' timeout='5'>
                            <Arguments>
                                <Argument />
                            </Arguments>
                        </Process>
                        <Message text='$(ipconfig_out)' />
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("Windows IP Configuration"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Util_Plugin()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test name='Test_Util_Plugin'>
                        <Import dll='CalcLib.dll' />

                        <Plugin name='CalcLib.dll'>
                          <Method name='plus' type='Calculator' out='plus_result'>
                            <Param>2</Param>
                            <Param>4</Param>
                          </Method>
                          <Method name='minus' type='CalculatorCore' out='minus_result'>
                            <Param>5</Param>
                            <Param>5</Param>
                          </Method>
                        </Plugin>  
                        <Assert expected='6' actual='$(plus_result)' condition='istrue' />
                        <Assert expected='0' actual='$(minus_result)' condition='istrue' />              
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Console.WriteLine(FunctMetaL.Util.Logger.Log.ToString());
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("Assert Actual: 6, Expected: 6, Condition: istrue, Result: PASS"),
                FunctMetaL.Util.Logger.Log.ToString());
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("Assert Actual: 0, Expected: 0, Condition: istrue, Result: PASS"),
                FunctMetaL.Util.Logger.Log.ToString());
            
        }

        [TestMethod]
        public void Test_Util_Plugin_WatiN()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Import dll='CalcLib.dll' />
                        <Import dll='TestWatiN.dll' />
                        <Import dll='WatiN.Core.dll' />

                        <Plugin name='TestWatiN.dll'>
                          <Method name='SearchForWatiNOnGoogle' type='GoogleTest' out='watin_result'>
                          </Method>
                        </Plugin>    
                        <Message text='$(watin_result)' />                    
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("pass"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_DoWhile()
        {            
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='1' />
                        <Variable name='y' value='1' />
                        <DoWhile left='$(x)' condition='-gt' right='$(y)'>
    	                  <Message text='Do While loop value $(x)' />
                        </DoWhile>
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("Do While loop value 1"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_Variable()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='1' />
                        <Message text='$(x)$(x)and$$(x)' />                        
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("11and$1"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_Array()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='1' />
                        <Variable name='y' value='2' />
                        <Array name='arr'>
                          <Item>1</Item>
                          <Item>2</Item>
                          <Item>3</Item>
                        </Array>
                        <Message text='@@(arr[0])@@(arr[$(y)])@@(arr[$(x)])' />
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Trim().Contains("@1@3@2"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_Assert()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='1' />
                        <Variable name='y' value='1' />
                        <Assert condition='IsTrue' expected='$(y)' actual='$(x)' out='assert_result' />
                        <Message text='$(assert_result)' />
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("true"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_Core_Eval()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Variable name='x' value='1' />
                        <Eval variable='$(x)' expression='++' />
                        <Message text='$(x)' />                        
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(FunctMetaL.Util.Logger.Log.ToString().Contains("2"),
                FunctMetaL.Util.Logger.Log.ToString());
        }

        [TestMethod]
        public void Test_BDD_Story()
        {
            FunctMetaL.Core.Main main = new Main();
            string filePath = Path.GetTempFileName();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                
                sw.Write(@"
                    <TestSuite>
                      <Test>
                        <Story>
                          <Scenario>
                            <Given>
                              <Action>Setting variable x with value 0</Action>
                              <Variable name='x' value='0' />
                            </Given>
                            <When>
                              <Action>Increment the value by 1</Action>
                              <Eval variable='$(x)' expression='++' />
                            </When>
                            <Then>
                              <Action>The value of the variable should be equal to 1</Action>
                              <Assert actual='$(x)' expected='1' condition='IsTrue' />
                            </Then>
                          </Scenario>
                        </Story>
                      </Test>
                    </TestSuite>");
            }
            main.TestSuite = filePath;
            main.Start();
            Assert.IsTrue(Logger.Log.ToString().Contains("Assert Actual: 1, Expected: 1, Condition: IsTrue, Result: PASS"),
                Logger.Log.ToString());
        }
    }
}
