#define LEVEL_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankSystem
{
#if LEVEL_1
    //Account (통장 관리) 클리스 만들기

    class Account
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

#elif LEVEL_2
    //Account (통장 관리) 클래스를 구성할
    //인스턴스 필드 (계좌번호, 계좌주, 잔액)을 추가하기

    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
#elif LEVEL_3
    //입금(Deposit),출금(Withdraw) 기능 메소드로 구현하기
    //입금액은 0이상의 금액이 들어와야 하며
    //출금액은 현재 잔액(Balance)보다 크면 안된다.
    //
    //ToString() 메소드를 override(재정의)하여 현재 통장 정보를
    //문자열로 만들어 반환할 수 있도록 한다.
    //object 클래스가 물려준 ToString()은 문자열을 반환하는 메소드이며    
    //override를 통해 원하는 문자열로 반환할 수 있도록 재정의가 가능하다.
    //
    //통장 정보를 문자열로 조합할 때 StringBuilder를 이용하여
    //문자열 생성을 최소화한다.
    //Environment.NewLine은 현재 시스템에서 줄바꿈으로 사용하는 문자를 반환한다.
    //Window의 경우 실제 줄바꿈 문자는 "\r\n"이다.

    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
#elif LEVEL_4
    //Console.WriteLine()은 다양한 타입의 값을 받아서.
    //문자열로 변환하여 Console화면에 출력하는 기능을 갖고 있다.
    //
    //Console 메소드가 문자열로 변환하는 것이 아니라.
    //모든 클래스에서 갖고 있는 ToString()을 통해 문자열을 얻어오고
    //해당 문자열을 화면에 출력하는 것이다.
    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            Account acc2 = new Account();

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc1);

            Console.WriteLine(acc2.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_5
    //Main()에서 생성한 Account 인스턴스의 필드에
    //필요한 정보를 설정한다.
    //
    //public 필드이기 때문에
    //.(dot) 연산자를 통해 직접 값을 설정할 수 있다.
    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            Account acc2 = new Account();

            acc1.Number = "001-23456-02-1234";
            acc1.Owner = "김인하";
            acc1.Balance = 2000;

            acc2.Number = "001-23456-02-5678";
            acc2.Owner = "김융합";
            acc2.Balance = 12000;

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_6
    //입급(Deposit) 메소드를 실행해서 입금을 수행한다.
    //반환값(bool)을 통해 입금 실패시 화면에 출력하도록 한다.
    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            Account acc2 = new Account();

            acc1.Number = "001-23456-02-1234";
            acc1.Owner = "김인하";
            acc1.Balance = 2000;

            acc2.Number = "001-23456-02-5678";
            acc2.Owner = "김융합";
            acc2.Balance = 12000;

            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_7
    //출금(Withdraw) 메소드를 실행해서 출금을 수행한다.
    //반환값(bool)을 통해 출금 실패시 화면에 출력하도록 한다.
    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            Account acc2 = new Account();

            acc1.Number = "001-23456-02-1234";
            acc1.Owner = "김인하";
            acc1.Balance = 2000;

            acc2.Number = "001-23456-02-5678";
            acc2.Owner = "김융합";
            acc2.Balance = 12000;

            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }

#elif LEVEL_8
    //인스턴스 필드를 생성시 원하는 값으로 초기화 할 수 있는
    //생성자를 추가한다.
    //기존 코드를 수정하지 않도록 기본 생성자도 추가한다.
    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            Account acc2 = new Account();

            acc1.Number = "001-23456-02-1234";
            acc1.Owner = "김인하";
            acc1.Balance = 2000;

            acc2.Number = "001-23456-02-5678";
            acc2.Owner = "김융합";
            acc2.Balance = 12000;

            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_9
    //새로 추가한 생성자를 사용할 수 있도록 코드를 변경한다.
    class Account
    {
        public string Number;
        public string Owner;
        public int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account();

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            acc2.Number = "001-23456-02-5678";
            acc2.Owner = "김융합";
            acc2.Balance = 12000;

            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_10
    //인스턴스 필드는 보통 private으로 해야한다.
    //LEVEL_9까지는 편의성 때문에 모두 public으로 변경했다.
    //이는 객체지향의 캡슐화를 제대로 구현하지 않은 것이다.
    //
    //Main()메소드에서 더 이상 직접 필드에 접근할 수 없게 된다.
    
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account();

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            acc2.Number = "001-23456-02-5678";
            acc2.Owner = "김융합";
            acc2.Balance = 12000;

            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_11
    //Main()메소드에서 직접 필드에 접근하여 값을 설정하지 않도록
    //추가한 생성자를 이용해서 Account()를 생성한다.
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account("001-23456-02-5678", "김융합", 12000);

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            //acc2.Number = "001-23456-02-5678";
            //acc2.Owner = "김융합";
            //acc2.Balance = 12000;

            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_12
    //Withdraw()메소드의 접근 제한자를 private으로 변경해보았다.
    //Main() 메소드의 Widthdraw() 호출 코드에 접근이 불가능하여 에러가 발생한다.
    //메소드에도 외부에서 접근하지 못하도록 private 처리하는 경우도
    //있다는 사실 잊지말자
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                return true;
            }
        }

        private bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account("001-23456-02-5678", "김융합", 12000);

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            //acc2.Number = "001-23456-02-5678";
            //acc2.Owner = "김융합";
            //acc2.Balance = 12000;

            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_13
    //입금과 출금시 정상적으로 처리된 경우 Console화면에 출력할 수 있도록 코드를 추가했다.
    //해당 방식은 UI등과의 호환성을 생각하면 좋은 방법은 아니나
    //내부의 ToString()을 호출하는 모습을 보여주기 위해서 추가한 것이다.
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                Console.Write("[입금처리]");
                Console.WriteLine($"입급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                Console.Write("[출금처리]");
                Console.WriteLine($"출급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account("001-23456-02-5678", "김융합", 12000);

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            //acc2.Number = "001-23456-02-5678";
            //acc2.Owner = "김융합";
            //acc2.Balance = 12000;


            if(false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }

#elif LEVEL_14
    //Main()메소드에 계좌번호와 이름만 넣은 생성자를 호출하는 
    //문장을 추가했다.
    //당연히 Account(string, string)형태의 생성자가 없기 때문에 에러가 발생한다.
    //해당 생성자는 잔액이 0원 통장을 만드는 경우를 위해 필요할 것으로 보인다.
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                Console.Write("[입금처리]");
                Console.WriteLine($"입급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                Console.Write("[출금처리]");
                Console.WriteLine($"출급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account("001-23456-02-5678", "김융합", 12000);
            Account acc3 = new Account("001-23456-02-9012", "김씨샵");

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            //acc2.Number = "001-23456-02-5678";
            //acc2.Owner = "김융합";
            //acc2.Balance = 12000;


            if (false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_15
    //LEVEL_14에서 언급한 생성자를 추가한다.
    //Balance의 기본 초기값이 0이기 때문에
    //추가한 생성자의 경우 별도로 Balance를 초기화하지 않아도
    //문제가 없다.
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public Account(string number, string owner)
        {
            this.Number = number;
            this.Owner = owner;
            //this.Balance = 0;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                Console.Write("[입금처리]");
                Console.WriteLine($"입급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                Console.Write("[출금처리]");
                Console.WriteLine($"출급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account("001-23456-02-5678", "김융합", 12000);
            Account acc3 = new Account("001-23456-02-9012", "김씨샵");

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            //acc2.Number = "001-23456-02-5678";
            //acc2.Owner = "김융합";
            //acc2.Balance = 12000;


            if (false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#elif LEVEL_16
    //Account()생성자가 3개가 되었다.
    //그 중 2개의 생성자는 유사한 코드가 중첩이 되어있다.
    //이를 방지하기 위해서 this() 생성자를 이용해 코드를 변경했다.
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
            : this(number, owner)
        {
            //this.Number = number;
            //this.Owner = owner;
            this.Balance = balance;
        }

        public Account(string number, string owner)            
        {
            this.Number = number;
            this.Owner = owner;
            //this.Balance = 0;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                Console.Write("[입금처리]");
                Console.WriteLine($"입급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if(Balance >= amount) {
                Balance -= amount;
                Console.Write("[출금처리]");
                Console.WriteLine($"출급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "김인하", 2000);
            Account acc2 = new Account("001-23456-02-5678", "김융합", 12000);
            Account acc3 = new Account("001-23456-02-9012", "김씨샵");

            //acc1.Number = "001-23456-02-1234";
            //acc1.Owner = "김인하";
            //acc1.Balance = 2000;

            //acc2.Number = "001-23456-02-5678";
            //acc2.Owner = "김융합";
            //acc2.Balance = 12000;


            if (false == acc1.Deposit(200)) {
                Console.WriteLine("입금실패1");
            }

            if(false == acc2.Deposit(3000)) {
                Console.WriteLine("입금실패2");
            }

            if (false == acc2.Deposit(-3000)) {
                Console.WriteLine("입금실패3");
            }

            if(false == acc1.Withdraw(10000)) {
                Console.WriteLine("잔액부족1");
            }

            if (false == acc2.Withdraw(10000)) {
                Console.WriteLine("잔액부족2");
            }

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2);
        }
    }
#else
    //Account를 생성할 때 변수에 넣는 것이 아니라
    //List를 이용하도록 변경하였다.
    class Account
    {
        private string Number;
        private string Owner;
        private int Balance;

        public Account() { }
        public Account(string number, string owner, int balance)
            : this(number, owner)
        {
            //this.Number = number;
            //this.Owner = owner;
            this.Balance = balance;
        }

        public Account(string number, string owner)
        {
            this.Number = number;
            this.Owner = owner;
            //this.Balance = 0;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0) {
                return false;
            } else {
                Balance += amount;
                Console.Write("[입금처리]");
                Console.WriteLine($"입급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            }
        }

        public bool Withdraw(int amount)
        {
            if (Balance >= amount) {
                Balance -= amount;
                Console.Write("[출금처리]");
                Console.WriteLine($"출급액:{amount}");
                Console.WriteLine(this.ToString());
                return true;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("계좌:").Append(Number).Append(Environment.NewLine);
            sb.Append("소유:").Append(Owner).Append(Environment.NewLine);
            sb.Append("잔액:").Append(Balance).Append(Environment.NewLine);
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("001-23456-02-1234", "김인하", 2000));
            accounts.Add(new Account("001-23456-02-5678", "김융합", 12000));
            accounts.Add(new Account("001-23456-02-9012", "김씨샵"));

            foreach (var acc in accounts) {
                Console.WriteLine(acc);
            }
        }
    }
#endif
}
