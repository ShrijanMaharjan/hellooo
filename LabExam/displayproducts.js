import { products } from "./products.js";

export function displayProducts() {
  console.log("PRODUCT LIST:");
  products.forEach((p) => {
    console.log(`${p.id}. ${p.name} - $${p.price}`);
  });
}
