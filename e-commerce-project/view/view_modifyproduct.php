<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <base href="<?= $web_root ?>"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/modifyproduct.css" rel="stylesheet" type="text/css"/>
        <script src="lib/jquery-2.2.0.min.js" type="text/javascript"></script>
        <script src="lib/jquery-validation-1.14.0/jquery.validate.js" type="text/javascript"></script>
        <script>
            var add,quantity;
        
            document.onreadystatechange = function () {
                if (document.readyState === 'complete') {
                    add = document.getElementById("add");
                    quantity = document.getElementById("wanted_quantity");
                }
            };
                 $.validator.addMethod("regex", function (value, element, pattern) {
                if (pattern instanceof Array) {
                    for(p of pattern) {
                        if (!p.test(value))
                            return false;
                    }
                    return true;
                } else {
                    return pattern.test(value);
                }
            }, "Please enter a valid input.");
        
        
           $(function () {
    
        $('#form').validate({
            rules: {
                 name: {
                    required: true,
                    minlength: 3,
                    maxlenght: 30,
                    regex: /^[A-zÀ-ÿ'0-9\- \s \é \è \ê \î \ï]+$/
                },
                category: {
                    required: false,
                    minlength: 3,
                    maxlenght: 30,
                    regex: /^[A-zÀ-ÿ'0-9\- \s \é \è \ê \î \ï]+$/
                    
                },
                description: {
                    required: true,
                    minlength: 10,
                    maxlenght: 200,
                    regex: /^[A-zÀ-ÿ'0-9\- \s \é \è \ê \î \ï]+$/
                },
                price: {
                    required: false,
                    min: 0.01,
                    number:true
                  
                },
                quantity: {
                    required: false,
                    min: 0,
                    digits: true
                }
                   
            },
            messages: {
                name: {
                    required: 'name required',
                    minlength: 'Too short',
                    maxlenght: 'Too long'
                   
                },
                category: {
                    
                    required: 'category required',
                    minlength: 'Too short',
                    maxlenght: 'Too long'
                    
                },
                description: {
                    required: 'description required',
                    minlength: 'Too short',
                    maxlenght: 'Too long'
                   
                },
                price: {
                    
                    min: 'Not enought'
                },
                quantity: {
                    
                    min: 'Impossible,you have to enter 0 or more' 
                }
                
            }
           
        });
        $("input:text:first").focus();
    });
    
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
        <h2>Ajout produit <?= $product->name ?></h2>
        <div class="ajout">
            <form action="basket/add_good" method="post">
                <p>Ajouter au panier :</p>
                <p>
                    <label>Quantité souhaitée: </label><input class="wanted_quantity" id="wanted_quantity" onchange="verify_quantity()" type="number" name="quantity" value="0"/>
                </p>
                <input type="hidden" name="product_id" value="<?= $id ?>" />
                <input type="submit" id="add" value="Ajouter"/>
                <p id="errorStock"></p>
            </form>
        </div>
        <h2>Modifier produit</h2>
        <section class="main-container">
            <form id="form" action="product/modifyproduct/<?= $id ?>" method="post" enctype='multipart/form-data'>
                <p>
                    <label>Name :</label> 
                    <input name="name" type="text" value="<?= $product->name ?>" />
                </p>
                <p>
                    <label>Description :</label>
                    <textarea name="description" cols="40" rows="10"><?= $product->description ?></textarea>
                </p>
                <p>
                    <label>Prix :</label>
                    <input name="price" type="number" value="<?= $product->price ?>" />
                </p>
                <p>
                    <label>Quantité :</label>
                    <input name="quantity" type="number" value="<?= $product->quantity ?>" />
                </p>
                <p>
                    <input class="send" type="submit" value="Modifier" />
                    <input class="send" type="reset"  value="Reset"/>
                </p>
            </form>
            <?php if(count($success)!=0): ?>
                <div class='success'>
                    <ul>
                    <?php foreach($success as $succes): ?>
                        <p><?= $succes ?></p>
                    <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>
            <?php if(count($product_errors)!=0): ?>
                <div class='errors'>
                    <ul>
                    <?php foreach($product_errors as $error): ?>
                        <p><?= $error ?></p>
                    <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>
            <h3>Liste des photos</h3>
            <form action="product/add_picture/<?=$id?>" method="post" enctype="multipart/form-data">
                <p>
                    <label>Ajouter photo :</label>
                    <input name="picture" type="file" />
                </p>
                <p>
                    <input class="send" type="submit" value="Ajouter" />
                </p>
            </form>
            <section class="photos">
                <?php foreach($pictures as $picture): ?>
                <div>
                    <img class="img-modify-product" src="<?= $picture['path'] ?>" />
                    <?php if($picture['deleted']): ?>
                    <a class="restore" href="product/restorePicture/<?= $picture['id']?>">Restaurer</a>
                    <?php else: ?>
                    <a class="delete" href="product/deletePicture/<?= $picture['id']?>">Supprimer</a>
                    <?php endif; ?>
                </div>
                <?php endforeach; ?>
            </section>
            <?php if(count($picture_errors)!=0): ?>
                <div class='errors'>
                    <ul>
                    <?php foreach($picture_errors as $error): ?>
                        <p><?= $error ?></p>
                    <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>
            <h3>Liste des catégories</h3>
            <form action="product/add_category/<?=$id?>" method="post">
                <p>
                    <label>Ajouter catégorie :</label>
                    <select id="category" name="category">
                        <option value="Aucune">Aucune</option>
                        <?php foreach($allcategories as $category) : ?>
                        <option value="<?=$category['title']?>"><?=$category['title']?></option>
                        <?php endforeach; ?>  
                    </select>
                </p>
                <p>
                    <input class="send" type="submit" value="Ajouter" />
                </p>
            </form>
            <section class="categories">
                <?php foreach($categories as $category): ?>
                <div>
                    <p><?= $category['title'] ?></p>
                    <?php if($category['pc_deleted']): ?>
                    <a class="restore" href="product/restoreCategory/<?= $category['product_id']."_".$category['category_id'] ?>">Restaurer</a>
                    <?php else: ?>
                    <a class="delete" href="product/deleteCategory/<?= $category['product_id']."_".$category['category_id'] ?>">Supprimer</a>
                    <?php endif; ?>
                </div>
                <?php endforeach; ?>
            </section>
            <?php if(count($category_errors)!=0): ?>
                <br><br>
                <div class='errors'>
                    <ul>
                    <?php foreach($category_errors as $error): ?>
                        <p><?= $error ?></p>
                    <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>
        </section>   
        <?php include("footer.html"); ?>
    </body>
</html>
