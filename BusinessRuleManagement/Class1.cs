using System;

namespace BusinessRuleManagement
{
    public abstract class BusinessRulesEngine : IProduct
    {
        public abstract bool Pay(double amount);

        public void PayForTheProduct(double amount)
        {
            Pay(0.0);
        }
    }

    /// <summary>
    /// Physical Product Class
    /// </summary>
    public class PhysicalProduct : BusinessRulesEngine, ICommisionPayment
    {
        public override bool Pay(double amount)
        {
            //payment and adding to db code goes here
            this.GeneratePackingSlip();
            return true;
        }
        
        private void GeneratePackingSlip()
        {
            //code goes here for generating packing slip.
            Console.WriteLine("Generate packing Slip");
            this.CommisionPaymentToAgent();
        }

         public void CommisionPaymentToAgent()
        {
            Console.WriteLine("Payment to the agent");
        }
    }

    /// <summary>
    /// Book Class
    /// </summary>
    public class Book : BusinessRulesEngine, ICommisionPayment
    {
        public override bool Pay(double amount)
        {
            //payment and adding to db code goes here
            this.GenerateDuplicatePackingSlip();
            return true;
        }

        private void GenerateDuplicatePackingSlip()
        {
            //Generate duplicate packing slip for royale department
            Console.WriteLine("Generate Duplicate packing sllip for royale department");
            this.CommisionPaymentToAgent();
        }

        public void CommisionPaymentToAgent()
        {
            Console.WriteLine("Payment to the agent");
        }
    }

    /// <summary>
    /// Membership Class
    /// </summary>
    public class Membership : BusinessRulesEngine, IEmailNotification
    {
        public override bool Pay(double amount)
        {
            //payment and adding to db code goes here
            this.ActivateMembership();
            return true;
        }

        private void ActivateMembership()
        {
            //Activate the membership
            Console.WriteLine("Activate the Membership");
            //Mail send to customer
            this.ActivationUpgrade();
        }

        public void ActivationUpgrade()
        {
            Console.WriteLine("Dear Customer: Your Membership has been upgraded");
        }
    }

    /// <summary>
    /// Upgrade to membership Class
    /// </summary>
    public class UpgradeToMembership : BusinessRulesEngine, IEmailNotification
    {
        public override bool Pay(double amount)
        {
            //payment and adding to db code goes here
            this.UpgradeMembership();
            return true;
        }

        private void UpgradeMembership()
        {
            Console.WriteLine("Upgrade to Membership");
            this.ActivationUpgrade();
        }

        public void ActivationUpgrade()
        {
            Console.WriteLine("Dear Customer: Your Membership has been upgraded");
        }

    }

    /// <summary>
    /// Video To Ski Class
    /// </summary>
    public class VideoToSki : BusinessRulesEngine
    {
        public override bool Pay(double amount)
        {
            //payment and adding to db code goes here
            this.AddFreeAidVideo();
            return true;
        }

        private void AddFreeAidVideo()
        {
            Console.WriteLine("Add first free aid video");
        }
    }

    
}
