# GuitarStore — Fixes & Improvements

## Bug Fixes

### 1. Cart subtotal column displayed raw text instead of currency (Cart/Index.cshtml)
**Before:** `<td>@(item.Quantity* item.Price).ToString("C")</td>`  
**After:** `<td>@((item.Quantity * item.Price).ToString("C"))</td>`  
The `.ToString("C")` was outside the Razor `@()` expression, so it printed the literal string `.ToString("C")` in the browser.

### 2. Cart mutation actions used GET requests (CartController.cs)
**Before:** `Remove`, `Increase`, `Decrease` had no `[HttpPost]` attribute — any link/crawler could empty or modify a user's cart.  
**After:** All three are now `[HttpPost]`, and the views use `<form method="post">` buttons instead of `<a>` links.

### 3. CartController was missing a namespace declaration
**Before:** No `namespace GuitarStore.Controllers { }` wrapper.  
**After:** Added proper namespace to match the rest of the project.

### 4. Decrease action did nothing when quantity was 1
**Before:** Item stayed at quantity 1 forever with no feedback.  
**After:** When quantity reaches 1 and Decrease is pressed, the item is removed and a TempData message is shown.

### 5. Unnecessary and incorrect `using` imports in GuitarContext.cs
Removed `using System.Data.Common`, `using Microsoft.Identity.Client`, and `using System.IO` (not needed). Fixed `orderedItems` DbSet property name to `OrderedItems` (PascalCase convention).

### 6. Nullable reference type warnings in Guitar.cs and CartItem.cs
Added `= null!` initializers to non-nullable string properties to satisfy C# 8+ nullable reference type analysis.

### 7. Category `selected` attribute in Catalog filter always rendered `selected=""`
**Before:** `selected="@selected"` where `selected` was `""` — always rendered the attribute.  
**After:** Uses `selected="@(isSelected ? "selected" : null)"` so the attribute is only emitted when truly selected.

## Improvements

### Guitar model — added `Description` field
A nullable `Description` property was added to `Guitar` for richer product listings.

### Catalog view
- Shows result count ("Showing N guitar(s)")
- Displays guitar description when present
- Added a clear-filters (✕) button next to the Filter button
- Shows success toast after adding to cart (uses `TempData["CartMessage"]`)
- Category badge and price displayed more prominently on cards

### Cart view
- Quantity controls are now proper POST form buttons (not anchor links)
- Added "Continue Shopping" and "Proceed to Checkout" buttons
- Cleaner table header with dark theme

### Checkout page (new)
- Added `Cart/Checkout.cshtml` and `CartController.Checkout()` action
- Placeholder shipping form with order summary sidebar

### Layout (_Layout.cshtml)
- Navbar changed from `navbar-light bg-white` to `navbar-dark bg-dark` for better contrast
- Added 🎸 emoji to brand
- Removed "Privacy" from main nav (declutter)
- Cart badge now sums `Quantity` across all items (not just item count)

### Seed data (GuitarContext.cs)
- Fixed broken Wikipedia image URL
- Added 4 more guitars (Gibson Les Paul, Martin D-28, Taylor 214ce, Yamaha CG182S) with descriptions
- Each guitar has a `Description` filled in
