double subtotal = CalculateSubtotal(items);
double discountedPrice = ApplyDiscounts(subtotal);

double shippingFee = discountedPrice >= FREE_SHIPPING_THRESHOLD ? 0 : CalculateShipping(distance);

double finalAmount = discountedPrice + shippingFee;
