import { products } from "./products.js";

export let wishlist = [];

export function addToWishlist(productId) {
  const product = products.find((p) => p.id === productId);
  if (!product) return console.log("Product not found.");

  const exists = wishlist.find((w) => w.id === productId);
  if (!exists) wishlist.push(product);

  console.log(`${product.name} added to wishlist.`);
}
