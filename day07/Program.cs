namespace day07
{
    internal class Program
    {
        struct Position
        {
            public int x;
            public int y;
        }


        static void Main(string[] args)
        {
            bool gameOver = false;
            
            Position player;
            Position goal01; 
            Position goal02;//
            bool[,] map01;
            bool[,] map02;//
            

            Start(out map01, out goal01, out player, out goal02, out map02); 
            while (gameOver == false)
            {
                Render(map01, goal01, player, goal02);
                ConsoleKey key = Input();
                Update(map01, goal01, ref player, ref gameOver, key, goal02, map02);//map02, //goal02

            }
            End();

        }



        static void Start( out bool[,] map01, out Position goal01, out Position player, out Position goal02, out bool[,] map02)//goal02
        {
            player.x = 1;
            player.y = 1;

            goal01.x = 13;
            goal01.y = 13;

            goal02.x= 1;//
            goal02.y= 13;//
            

            Console.CursorVisible = false;

            map01 = new bool[15, 15]
            {   //  0      1      2      3      4      5       6     7      8       9    10     11      12     13    14      
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, // 0
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 1
                { false, false, false, false, false, false, false, false, false, false, false, false, false, true,  false }, // 2
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 3
                { false, true,  false, false, false, false, false, false, false, false, false, false, false, false,  false }, // 4
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 5
                { false, false, false, false, false, false, false, false, false, false, false, false, false,  true,  false }, // 6
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 7
                { false, true,  false, false, false, false, false, false, false, false, false, false, false, false,  false }, // 8
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 9
                { false, false, false, false, false, false, false, false, false, false, false, false, false,  true,  false }, // 10
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 11
                { false, true,  false, false, false, false, false, false, false, false, false, false, false, false,  false }, // 12
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 13
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false } // 14
               
            };

            map02 = new bool[15, 15]
            {   //  0      1      2      3      4      5       6     7      8       9    10     11      12     13    14      
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, // 0
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 1
                { false, false, false, false, false, false, false, false, false, false, false, false, false, true,  false }, // 2
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 3
                { false, true,  false, false, false, false, false, false, false, false, false, false, false, false,  false }, // 4
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 5
                { false, false, false, false, false, false, false, false, false, false, false, false, false,  true,  false }, // 6
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 7
                { false, true,  false, false, false, false, false, false, false, false, false, false, false, false,  false }, // 8
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 9
                { false, false, false, false, false, false, false, false, false, false, false, false, false,  true,  false }, // 10
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 11
                { false, true,  false, false, false, false, false, false, false, false, false, false, false, false,  false }, // 12
                { false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false }, // 13
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false } // 14
               
            };


        }

        static void Render(bool[,] map01, Position goal01, Position player, Position goal02)// goal 출력 문제
        {
            Console.SetCursorPosition(0, 0);
            PrintMap(map01);
            PrintGoal01(goal01);
            PrintGoal02(goal02);//
            PrintPlayer(player);
        }

        static void PrintMap(bool[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for(int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == false)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }

        static void PrintGoal01(Position goal01)
        {
            Console.SetCursorPosition(goal01.x, goal01.y);
            Console.Write("G1");

        }
        static void PrintGoal02(Position goal02)
        {
            Console.SetCursorPosition(goal02.x, goal02.y);
            Console.Write("G2");

        }


        static void PrintPlayer(Position player)
        {
            Console.SetCursorPosition(player.x, player.y);
            Console.Write("P");

        }


       

        static ConsoleKey Input()
        {
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }


        static void Update(bool[,] map01, Position goal01, ref Position player, ref bool gameOver, ConsoleKey key, Position goal02, bool[,] map02)//map02, goal02
        {
            // 키입력
            Move(key, ref player);


            //충돌시 위치 초기화
            if (Wall(player, map01))
            {
                player.x = 1;
                player.y = 1;
            }

            // goal01 도착지 map02을 출력, goal01폐기
            if (GameClear(player, goal01))
            {
                map01 = map02;
                goal01.x = -1;
                goal01.y = -1;
            }



            //bool isclear = GameClear(player, goal01);



            // 게임종료
            if (GameClear(player,goal01))
            {
                gameOver = true;
            }
            
           
            
        }
        static bool GameClear(Position player, Position goal)
        {
            return (player.x == goal.x) && (player.y == goal.y);
        }
       

        static bool Wall(Position player, bool[,] map)
        {
            return map[player.y, player.x] == false;
        }



        static void Move(ConsoleKey key, ref Position player)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                        player.x--;
                    break;

                case ConsoleKey.RightArrow:
                        player.x++;
                    break;

                case ConsoleKey.UpArrow:
                        player.y--;                    
                    break;

                case ConsoleKey.DownArrow:                   
                        player.y++;                
                    break;
            }
        }


        



        static void End()
        {
            Console.Clear();
            Console.WriteLine("클리어!");
        }




     }

    }


  