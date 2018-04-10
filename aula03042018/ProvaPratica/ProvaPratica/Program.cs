using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo0 = new Veiculo();
            Carro veiculo1 = new Carro();
            Fusca veiculo2 = new Fusca();
            PicapeS10 veiculo3 = new PicapeS10();
            Motocicleta veiculo4 = new Motocicleta();
            Cb200 veiculo5 = new Cb200();
            Embarcacao veiculo6 = new Embarcacao();
            Caiaque veiculo7 = new Caiaque();
            Aeronave veiculo8 = new Aeronave();
            Esquilo veiculo9 = new Esquilo();
            Legacy450 veiculo10 = new Legacy450();

            veiculo0.setMarca("FIAT");
            veiculo0.setAno(1999);
            veiculo0.setPneu(4);

            veiculo1.setMarca("Ferrari");
            veiculo1.setAno(2002);
            veiculo1.setPneu(4);
            veiculo1.setCorCarro("Vermelho");

            veiculo2.setMarca("Volkswagen");
            veiculo2.setAno(1972);
            veiculo2.setPneu(4);
            veiculo2.setCorCarro("Amarelo");

            veiculo3.setMarca("Chevrolet");
            veiculo3.setAno(2018);
            veiculo3.setPneu(4);
            veiculo3.setCorCarro("Preto");

            veiculo4.setMarca("Honda");
            veiculo4.setAno(2004);
            veiculo4.setPneu(2);
            veiculo4.setCorMotocicleta("Cinza");

            veiculo5.setMarca("Honda");
            veiculo5.setAno(1975);
            veiculo5.setPneu(2);
            veiculo5.setCorMotocicleta("Cinza");

            veiculo6.setMarca("Amerigo Vespucci");
            veiculo6.setAno(1930);
            veiculo6.setPneu(0);
            veiculo6.setCorCasco("Preto e Branco");

            veiculo7.setMarca("Caiaque Lontras");
            veiculo7.setAno(2016);
            veiculo7.setPneu(0);
            veiculo7.setCorCasco("Azul");

            veiculo8.setMarca("Agusta");
            veiculo8.setAno(1996);
            veiculo8.setPneu(3);
            veiculo8.setCorFuselagem("Cinza");

            veiculo9.setMarca("Helibrás");
            veiculo9.setAno(2016);
            veiculo9.setPneu(0);
            veiculo9.setCorFuselagem("Branco");

            veiculo10.setMarca("Embraer");
            veiculo10.setAno(2015);
            veiculo10.setPneu(6);
            veiculo10.setCorFuselagem("Branco");

            Console.WriteLine(veiculo0.ToString());
            veiculo0.locomover();
            veiculo0.abastecer();
            Console.WriteLine(veiculo1.ToString());
            Console.WriteLine(veiculo2.ToString());
            veiculo2.locomover();
            veiculo2.abastecer();
            Console.WriteLine(veiculo3.ToString());
            veiculo3.locomover();
            veiculo3.abastecer();
            Console.WriteLine(veiculo4.ToString());
            Console.WriteLine(veiculo5.ToString());
            veiculo5.locomover();
            veiculo5.abastecer();
            Console.WriteLine(veiculo6.ToString());
            veiculo6.ancorar();
            Console.WriteLine(veiculo7.ToString());
            veiculo7.locomover();
            veiculo7.abastecer();
            veiculo7.ancorar();
            Console.WriteLine(veiculo8.ToString());
            veiculo8.arremeter();
            Console.WriteLine(veiculo9.ToString());
            veiculo9.locomover();
            veiculo9.abastecer();
            veiculo9.arremeter();
            Console.WriteLine(veiculo10.ToString());
            veiculo10.locomover();
            veiculo10.abastecer();
            veiculo10.arremeter();
            veiculo10.decolar("sol");
            veiculo10.decolar(19);
            veiculo10.decolar(true);

            Console.ReadKey();
        }
    }
}
