using System;
using SimpleFactory.Enum;
using SimpleFactory.Products;


namespace SimpleFactory.ProductFactory
{
   public static class Factory
    {
        public static IMobile CreateMobile(MobileType mobileType)
        {
            switch (mobileType)
            {
                case MobileType.Nokia:
                {
                    return new Nokia("N90", 400m);
                }
                case MobileType.Samsung:
                {
                    return new Samsung("Galaxy", 500m);
                }
                case MobileType.Sony:
                {
                    return new Sony("Xperia L4", 600m);
                }
                default:
                {
                    throw new ArgumentException("Invalid mobile type.");
                }
            }
        }
    }
}
