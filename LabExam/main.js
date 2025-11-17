import { displayProducts } from "./displayproducts.js";
import { addToCart, displayCart } from "./cart.js";
import { addToWishlist } from "./wishlist.js";
import { checkout } from "./checkout.js";

// DEMO RUN

displayProducts();
addToCart(1);
addToCart(1);
addToWishlist(2);
addToCart(2);

displayCart();
checkout();
