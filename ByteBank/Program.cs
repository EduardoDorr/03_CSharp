using ByteBank.Employees;
using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
  class Program {
    static void Main(string[] args) {
      //ComputeBonus();
      UseSystem();

      Console.ReadLine();
    }

    public static void ComputeBonus() {
      GetBonus manager = new GetBonus();

      Designer john = new Designer("458.854.215-78");
      john.Name = "John";

      Director robert = new Director("014.312.466-15");
      robert.Name = "Robert";

      AccountManager bob = new AccountManager("214.698.854-25");
      bob.Name = "Bob";

      Dev ruri = new Dev("589.325.754-46");
      ruri.Name = "Ruri";

      Auxiliary bill = new Auxiliary("023.675.359-46");
      bill.Name = "Bill";

      manager.Register(john);
      manager.Register(robert);
      manager.Register(bob);
      manager.Register(bill);
      manager.Register(ruri);

      Console.WriteLine("Total bonus on last month: " + manager.GetBonusTotal());
    }

    public static void UseSystem() {
      InternSystem internSystem = new InternSystem();

      Director robert = new Director("014.312.466-15");
      robert.Name = "Robert";
      robert.CreatePassword("123");

      AccountManager bob = new AccountManager("214.698.854-25");
      bob.Name = "Bob";
      bob.CreatePassword("abc");

      ComercialPartner partner = new ComercialPartner();
      partner.CreatePassword("456");
      
      internSystem.Login(robert, "123");
      internSystem.Login(bob, "abd");
      internSystem.Login(partner, "456");      
    }
  }
}
