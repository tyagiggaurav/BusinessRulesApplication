using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Products
{
    public class Membership : IProduct
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Id { get; set; }
        public bool isCommissionGenerated { get; set; }

        public MembershipTypes membershipType { get; set; }

        public enum MembershipTypes
        {
            Regular,
            Premium
        }

        public Membership(string id, string name)
        {
            Id = id;
            Name = name;
            IsActive = false;
        }

        public void ActicateMemberShip(Membership membership)
        {
            membership.IsActive = true;
            SendIntimation(membership, true);
        }

        public void UpgradeMembership(Membership membership)
        {
            if (membership.membershipType == MembershipTypes.Regular)
            {
                membership.membershipType = MembershipTypes.Premium;
                SendIntimation(membership, false);

            }
        }

        void SendIntimation(Membership membership, bool isActivate)
        {
            if (isActivate)
            {
                Console.WriteLine(membership.Name + " has been activated");
            }
            else
            {
                Console.WriteLine(membership.Name + " has been updated");
            }

        }
    }
}
