using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ders16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = 5;
            /* 
             
            **** TAPŞIRIQ VERİLSİN ****
            polimorphism çox funksionallılıq 
            method overloading || method overriding 
            override + method 
            inheritance
            base derived 
            protected
            sealed class inherite olmur
            static class obyektini yaratmaq olmur
            :base() keyword 
            ilk olaraq :base() in ctoru isleyir
            SOLID
            S=Single Responsibility(hər methoda,classa ve s. bir iş vermək lazımdır)
            O=Open Closed(kodları silməsən yaxşıdı,dəyişiklik olduqda əlavə etmək lazımdır)
            L=Liskovs substition(base derivedi hər şəkildə əvəz edə bilməlidir)(derived base ni əvəz edə bilmız)
            İnheritance deyiləndə ağlınıza liskov gəlsin
            extension methods 
            Separation of concerns
            OOP nin prinsipleri:
              Polimorphism
               Inheritance
                 Encapsulation(Datanı qorumaq üçündür)
                  Abstraction(Datanı gizlətmək və lazım olanları göstərmək üçündür)

           
              
            Abstract keyword
            Abstract classın obyektini yaratmaq olmur
            Abstract methodun body {içi olmur} olmur {} bu da olmur heç
            Abstract olan şeyıər inherite olduğu yerdə implement olunmalıdır
            Abstract Virtuala bənzəyir ama fərq var
            Abstractın implementini yaradılması məcburidir, Virtualda sərbəstdir
            Abstract Abstract classın içində istifadə olunur
            Bir Class ancaq bir class ı özünə inherite ede bilir
            Interface classın referance tutucusudur və bir class özünə birdən çox interface inherite ede biler
            İnterface in memberlərin default access modifiersi publicdir və bunu dəyişmək olmur
            İnterface memberleri sadəcə declare olunur və mütləq şəkildə implement olunmalıdır
            Abstract Class və İnterface fərqi
             1)Interface in bütün elementləri implemet olmalıdır və bir neçə inherite etmək şansı yaradır
              2)abstract classda isə ancaq abstract memberlər implement olmalıdır və sadəcə 1 dəfə inherite etmək şansı yaradır
               3)Interface də ctor yaratmaq olmur,amma abstract class da olur


             */

            Console.WriteLine(Cvad.c);

            Any any = new Any(17,"Cebi");

            string Some = "Cebi";
            Console.WriteLine(Some.Cvad());

            Mucarred mucarred= new Kamran();
            mucarred.Turxan();
            mucarred.Rehim(5);

            Iface face=new Face();
            Iface fase = new Some(1,"knn");
            

            Console.ReadLine();
        }
    }
}
