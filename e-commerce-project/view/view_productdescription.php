<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <base href="<?= $web_root ?>"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/productdescription.css" rel="stylesheet" type="text/css"/>
        <script>
        
        var add,quantity;
        
        document.onreadystatechange = function () {
                if (document.readyState === 'complete') {
                    add = document.getElementById("add");
                    quantity = document.getElementById("wanted_quantity");
                }
            };
                
        function verify_quantity()
        {
            var qty = parseInt(quantity.value);
            var stock = parseInt('<?= $product->quantity ?>');
            errorStock.innerHTML = "";
            if(qty > stock)
            {
                errorStock.innerHTML = "<span style='color:red'>Warning!There is only "+stock+" of this item in stock!</span>";
                add.disabled = true;
            }
            else if(qty <= 0)
            {
                errorStock.innerHTML = "<span style='color:red'>Can not buy null or negative value!</span>";
                add.disabled = true;
            }
            else
            {
                 add.disabled = false;
            }
        }
        
        </script>
    </head>
    <body>
        <?php include "header.html" ?>  
        <?php include($menu) ?>
        <h2>Description du produit</h2>
        <section class="main-container">
            <h3><?= $product->name ?></h3>
            <?php if($is_logged): ?>
                <form action="basket/add_good" method="post">
                    <p>Ajouter au panier :</p>
                    <p>
                        <label>Quantité souhaitée: </label><input class="wanted_quantity" id="wanted_quantity" onchange="verify_quantity()" type="number" name="quantity" value="0"/>
                    </p>
                    <input type="hidden" name="product_id" value="<?= $product_id ?>" />
                    <input type="submit" id="add" value="Ajouter"/>
                    <p id="errorStock"></p>
                </form>
            <?php endif; ?>
            <h4>Photos:</h4>
            <div class='photos'>
            <?php foreach($pictures as $picture): ?>
                <img src="<?=$picture['path']?>" />
            <?php endforeach; ?>
            </div>
            <div class='reste'>
                <h4>Description</h4>
                <p><?= $product->description ?></p>
                <h4>Prix:</h4>
                <p><?= $product->price ?> €</p>
                <h4>Quantité disponible:</h4>
                <p><?= $product->quantity ?></p>
            </div>
            <h4>Catégories:</h4>
            <div class="categories">
                <ul>
                <?php foreach($categories as $category): ?>
                    <li><?= $category['title'] ?></li>
                <?php endforeach; ?>
                </ul>
            </div>
        </section>
        <?php include("footer.html"); ?>
    </body>
</html>