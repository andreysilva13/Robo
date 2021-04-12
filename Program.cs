using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do grid");
            Console.Write("Digite o valor X: ");
            int xgrid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor Y: ");
            int ygrid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite a posição do robo");
            Console.Write("Digite o valor X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x>xgrid || x<0)
            {
                Console.WriteLine("Posição fora do grid ou negativo, digite outro número");
                Console.Write("Digite o valor X: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Digite o valor Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            while (y>ygrid || y<0)
            {
                Console.WriteLine("Posição fora do grid ou negativo, digite outro número");
                Console.Write("Digite o valor Y: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Em qual direção o robo esta olhando. (N) / (S) / (O) / (L): ");
            string pos = Console.ReadLine();

            while(pos != "N" && pos != "S" && pos != "O" && pos != "L" && pos != "n" && pos != "s" && pos != "o" && pos != "l")
            {
            Console.WriteLine("Direção inválida!");
            Console.Write("Em qual direção o robo esta olhando. (N) / (S) / (O) / (L): ");
            pos = Console.ReadLine();
            }
            string posFormatado = pos.ToUpper();

            Console.Write("Mova o robô com os seguintes comandos. E - VIRAR ESQUERDA / D - VIRAR DIREITA / M - SE MOVER PARA FRENTE");
            Console.WriteLine();
            string controleRobo = Console.ReadLine();      
            string controleRoboFormatado = controleRobo.ToUpper();
            int validaResultadoInt = 0;
            char[] charValida = controleRoboFormatado.ToCharArray();          
            foreach (char ch in charValida)
            {   
                if(ch == 'E' || ch == 'D' || ch == 'M')
                {
                    validaResultadoInt = 1; 
                }
                else
                {   
                    validaResultadoInt = 2;
                    break; 
                }
                continue;
            }

            char[] charValida2 = controleRoboFormatado.ToCharArray();          
            foreach (char ch in charValida2)
            {
                if(validaResultadoInt == 1)
                {
                    switch (ch)
                    {
                    case 'E':
                        if(posFormatado == "N" ){posFormatado = "O";}else

                        if(posFormatado == "O" ){posFormatado = "S";}else

                        if(posFormatado == "S" ){posFormatado = "L";}else

                        if(posFormatado == "L" ){posFormatado = "N";};
                        break;

                    case 'D':
                        if(posFormatado == "N" ){posFormatado = "L";}else

                        if(posFormatado == "L" ){posFormatado = "S";}else

                        if(posFormatado == "S" ){posFormatado = "O";}else

                        if(posFormatado == "O" ){posFormatado = "N";};
                        break;

                    case 'M':
                        if(posFormatado == "N" ){y++;}else

                        if(posFormatado == "L" ){x++;}else

                        if(posFormatado == "S" ){y--;}else

                        if(posFormatado == "O" ){x--;};
                        break;        
                    }
                }
                continue;
            }

            if(validaResultadoInt == 1)
                {
                Console.Write(x); Console.Write(y); Console.Write(posFormatado);
                Console.ReadLine();
                }
            while(validaResultadoInt == 2)
            {   
                Console.WriteLine("Não foi possível calcular a direção correta do robô, verifique a entrada de dados e tente novamente!");
                controleRobo = Console.ReadLine();      
                controleRoboFormatado = controleRobo.ToUpper();
                char[] charValida3 = controleRoboFormatado.ToCharArray();  
                foreach (char ch in charValida3)
            {   
                if(ch == 'E' || ch == 'D' || ch == 'M')
                {
                    validaResultadoInt = 1; 
                }
                else
                {   
                    validaResultadoInt = 2;
                    break; 
                }
                continue;
            }

            char[] charValida4 = controleRoboFormatado.ToCharArray();          
            foreach (char ch in charValida4)
            {
                if(validaResultadoInt == 1)
                {
                    switch (ch)
                    {
                    case 'E':
                        if(posFormatado == "N" ){posFormatado = "O";}else

                        if(posFormatado == "O" ){posFormatado = "S";}else

                        if(posFormatado == "S" ){posFormatado = "L";}else

                        if(posFormatado == "L" ){posFormatado = "N";};
                        break;

                    case 'D':
                        if(posFormatado == "N" ){posFormatado = "L";}else

                        if(posFormatado == "L" ){posFormatado = "S";}else

                        if(posFormatado == "S" ){posFormatado = "O";}else

                        if(posFormatado == "O" ){posFormatado = "N";};
                        break;

                    case 'M':
                        if(posFormatado == "N" ){y++;}else

                        if(posFormatado == "L" ){x++;}else

                        if(posFormatado == "S" ){y--;}else

                        if(posFormatado == "O" ){x--;};
                        break;        
                    }
                }
                continue;
                }

                if(validaResultadoInt == 1)
                {
                Console.Write(x); Console.Write(y); Console.Write(posFormatado);
                Console.ReadLine();
                }
            }
        }
    }
}

   
    

