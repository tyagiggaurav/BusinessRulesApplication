using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;

namespace BusinessRules.Commands
{
    public class SlipCommand : ICommand
    {
        readonly string operation;
        readonly IProduct product;
        public SlipCommand(string operation, IProduct product)
        {
            this.operation = operation;
            this.product = product;

            if (this.product is Video)
            {
                Video vid = this.product as Video;
                if (vid.Id == "Learning to ski")
                {
                    AddFreeVideo("First Aid");
                }
            }
        }


        void AddFreeVideo(string id)
        {
        }
    }
}
