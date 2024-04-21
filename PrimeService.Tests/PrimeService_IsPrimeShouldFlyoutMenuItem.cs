using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShouldFlyoutMenuItem
    {
        public PrimeService_IsPrimeShouldFlyoutMenuItem()
        {
            TargetType = typeof(PrimeService_IsPrimeShouldFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}