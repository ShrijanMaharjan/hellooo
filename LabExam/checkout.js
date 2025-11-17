import { cart } from "./cart.js";

export function calculateTotal() {
  let total = 0;

  cart.forEach((item) => {
    let discounted = item.price - (item.price * item.discount) / 100;
    let vatAdded = discounted + (discounted * item.vat) / 100;
    total += vatAdded * item.quantity;
  });

  return total.toFixed(2);
}

export function checkout() {
  if (cart.length === 0) return console.log("Cart is empty.");

  console.log("\n--- CHECKOUT ---");

  cart.forEach((item) => {
    console.log(
      `${item.name} | Qty: ${item.quantity} | Discount: ${item.discount}% | VAT: ${item.vat}%`
    );
  });

  console.log(`TOTAL PAYABLE: $${calculateTotal()}`);
}
