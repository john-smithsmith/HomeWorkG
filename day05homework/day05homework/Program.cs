using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace day05homework
{
    internal class Program
    {

        //Item 구조체
        //내부에 아래와 같은 데이터를 가진다
        //아이템 이름
        //아이템 고유 ID
        struct Item
        {
            public string name;
            public int id;
        }

        //2. Inventory 구조체
        //내부에 아래와 같은 데이터와 기능을 가진다
        //Item 구조체를 보관할 수 있는 배열
        //인벤토리 생성 후 내부에서 관리하는 인벤토리의 배열에 대한 크기를 지정할 수 있어야 한다.
        struct Inventory
        {
            public Item[] items;

            public Inventory(int size)
            {
                items = new Item[size];
            }

        }


        static void Main(string[] args)
        {

            //3. 메인 함수를 포함하고 있는 클래스에 함수 추가
            //Item 구조체를 입력 받아 이름과 고유 ID를 콘솔에 출력하는 함수 제작
            //Inventory 구조체를 입력받아 가지고 있는 아이템을 한줄에 하나씩 전부 출력하는 함수 제작

            Item soward;
            soward.name = "검";
            soward.id = 0;

            Item shield;
            shield.name = "방패";
            shield.id = 1;

            Item staff;
            staff.name = "지팡이";
            staff.id = 2;

            Inventory inventory = new Inventory(3);
            inventory.items[0] = soward;
            inventory.items[1] = shield;
            inventory.items[2] = staff;



            Console.WriteLine("아이템 목록:");
            foreach (Item item in inventory.items)
            {
                Console.WriteLine($"아이템 이름: {item.name}, 아이템 ID: {item.id}");
            }

        }
    }
}




