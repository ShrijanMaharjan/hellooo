import { products } from "./products.js";

export let cart = [];

export function addToCart(productId) {
  const product = products.find((p) => p.id === productId);
  if (!product) return console.log("Product not found.");

  const cartItem = cart.find((item) => item.id === productId);

  if (cartItem) {
    cartItem.quantity += 1;
  } else {
    cart.push({ ...product, quantity: 1 });
  }

  console.log(`${product.name} added to cart.`);
}

export function displayCart() {
  console.log("\nCART:");
  cart.forEach((item) => {
    console.log(`${item.name} - $${item.price} x ${item.quantity}`);
  });
}
