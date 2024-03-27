namespace Robo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * INFORMAÇÔES PRINCIPAIS
             * area total em formato de x e y
             * posição inicial do robo em x e y
             * informações de movimentação
             * 
             * precisa de estruturas de repetição em caso de erro:
             * while
             * for
             * 
             * estruturas de escolhas para trabalhar nas informações de movimento
             * switch-case
             * if-else
             */

            //Inserções do usuario
            char verifica = 'S';

            while (verifica == 'S' || verifica == 's')
            {
                #region insercoes do usuario
                #region area
                Console.WriteLine("Digite a área do X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a área do Y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region posicao inicial
                Console.WriteLine("Digite a posição X inicial do robo: ");
                int robox = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a posição Y inicial do robo: ");
                int roboy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite direção inicial do robo: \nN - norte \nL - leste \nS - sul \nO - oeste");
                string direction = Convert.ToString(Console.ReadLine());
                #endregion
                #endregion

                #region informacoes de movimento
                int xfinal = robox, yfinal = roboy;
                string right = "D";
                string left = "E";
                //string move = "M";
                string atualdirection = direction;
                Console.WriteLine("Digite a sequência de comando para o robo: ");
                string[] comands = Console.ReadLine().Split(" ");
                //Console.ReadLine();
                #endregion

                foreach (string i in comands)
                {
                    if (i == right)
                    {
                        switch (atualdirection)
                        {
                            case "N":
                                atualdirection = "L";
                                break;

                            case "L":
                                atualdirection = "S";
                                break;

                            case "S":
                                atualdirection = "O";
                                break;

                            case "O":
                                atualdirection = "N";
                                break;
                        }
                    }
                    else if(i == left)
                    {
                        switch (atualdirection)
                        {
                            case "N":
                                atualdirection = "O";
                                break;

                            case "L":
                                atualdirection = "N";
                                break;

                            case "S":
                                atualdirection = "L";
                                break;

                            case "O":
                                atualdirection = "S";
                                break;

                        }
                    }
                    else
                    {
                        switch (atualdirection)
                        {
                            case "N":
                                yfinal++;
                                break;

                            case "S":
                                yfinal--;
                                break;

                            case "L":
                                xfinal++;
                                break;

                            case "O":
                                xfinal--;
                                break;

                        }
                    }
                }

                Console.WriteLine($"({xfinal},{yfinal}) {atualdirection}");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Deseja continuar? Digite 's' para continuar");
                verifica = Convert.ToChar(Console.Read());
                
            }

        }
    }
}
