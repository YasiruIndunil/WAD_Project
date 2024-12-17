


        $.ajax({
            async: true,
            type: 'POST',
            url: '@Url.Action("AddedCartItems", "Ordering")',
            success: function (data) {

                if (data && data.length > 0) {
                    var itemQty = data.reduce((total, item) => total + item.Quantity, 0); // Calculate total quantity in the cart
                    updateCartBadge(itemQty); // Update the cart badge with the total quantity
                } else {
                    console.error('No items in the cart.');
                }
            },
            error: function (xhr, status, error) {
                console.error('Error adding to cart:', error);
            }


        });
 
  
