using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ProjException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Main() 호출 -> CLR
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
#if false
            Test6();
#else
            try{
                Test6(); 
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
                Console.WriteLine(ex.ToString()); // save to file..
            }
#endif
        }
        static void Test1()
        {
            var name = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"=={name}=================");

            int a = 0;
            int[] b = new int[] { 3, 4, 5, 6 };

            try {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(b[a]);
            }
            catch
            {
                Console.WriteLine("Err!!");
            }
            
        }   
        static void Test2()
        {
            var name = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"=={name}=================");


            int a = 0;
            int[] b = new int[] { 3, 4, 5, 6 };

            try
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(b[a]);
            }
            finally
            {
                Console.WriteLine("Err?");
            }

        }
        static void Test3()
        {
            var name = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"=={name}=================");


            int a = 0;
            int[] b = new int[] { 3, 4, 5, 6 };

            try
            {
                a = int.Parse(Console.ReadLine()); //err1
                Console.WriteLine(b[a]); //err2
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("----------");

                // 밑에 두개는 같음
                //Console.WriteLine(ex.ToString());
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Err?");
            }
        }
        static void Test4()
        {
            var name = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"=={name}=================");

            int a = 0;
            int[] b = new int[] { 3, 4, 5, 6 };

            try {
                a = int.Parse(Console.ReadLine()); //err1
                Console.WriteLine(b[a]); //err2
            }catch (IndexOutOfRangeException ex) {
                Console.WriteLine($"입력은 0~{(b.Length-1)}사이 값을 넣어요!");
                Console.WriteLine(ex); // 추후 파일에 저장하기
            }catch (FormatException ex) {
                Console.WriteLine($"정수형 숫자를 적어주세요!");
                Console.WriteLine(ex); // 추후 파일에 저장하기
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex); // 추후 파일에 저장하기
            } finally {
                Console.WriteLine("Err?");
            }
        }
        static void Test5()
        {
            var name = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"=={name}=================");

            int a = 0;
            int[] b = new int[] { 3, 4, 5, 6 };

            try
            {
                a = int.Parse(Console.ReadLine()); //err1
                Console.WriteLine(b[a]); //err2
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"입력은 0~{(b.Length - 1)}사이 값을 넣어요!");
                return;
                Console.WriteLine(ex); // 추후 파일에 저장하기
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"정수형 숫자를 적어주세요!");
                return;
                Console.WriteLine(ex); // 추후 파일에 저장하기
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
                Console.WriteLine(ex); // 추후 파일에 저장하기
            }
            finally {
                Console.WriteLine("Err?");
            }
        }
        static void Test6()
        {
            var name = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"=={name}=================");

            throw new NotImplementedException();
        }
        
    }
}
