<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <base href="<?= $web_root ?>"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/productslist.css" rel="stylesheet" type="text/css"/>
        <script>
            var btn, list, min, max;
            document.onreadystatechange = function () {
                if (document.readyState === 'complete') {
                    btn = document.getElementById("btn");
                    list = document.getElementById("list");
                    min = document.getElementById("min_price");
                    max = document.getElementById("max_price");
                    load_products();
                    
                }
            };
          
            function verify_prices()
            { 
                var min_price = parseInt(min.value);
                var max_price = parseInt(max.value);
                errorValues.innerHTML = "";
                
                if(min_price > max_price)
                {   
                    errorValues.innerHTML = "<span style='color:red'>Warning!The minimum value can not be superior to the maximum value!</span>";
                    btn.disabled = true;
                }
                
                else{
                   
                    btn.disabled = false;
                    }
            
            }
          
            
            function load_products(){
                var category = document.getElementById("category").options[document.getElementById('category').selectedIndex].text;
                var min_price = document.getElementById("min_price").value;
                var max_price = document.getElementById("max_price").value;
                var search = document.getElementById("search").value;
                var admin = <?= $admin ?>;
                
               
                var xhttp = new XMLHttpRequest();
                
                xhttp.onreadystatechange = function () {
                    if (xhttp.readyState === 4 && xhttp.status === 200) {
                        btn.disabled = false;
                        var obj = JSON.parse(xhttp.responseText);
                        list.innerHTML = "";
                        
                      
                        for (var p of obj.products) {
                            if(p.name.length > 14)
                                p.name = p.name.substr(0, 13)+"...";
                            
                            <?php if($admin):?>
                                if(p.deleted == 1)
                                    p.deleted = "<a class='restore' href='product/restore_product/"+p.id+"'>Restaurer</a>";
                                else
                                    p.deleted = "<a class='delete' href='product/delete_product/"+p.id+"'>Supprimer</a>";
                                list.innerHTML += ("<div class='product-wrapper'><a class='product-admin' href='product/modifyproduct/"+p.id+"'><h4>"+p.name+"</h4><img src='"+p.path+"'></a>"+p.deleted+"</div>");
                            <?php else: ?>
                                list.innerHTML += ("<a class='product' href='product/productdescription/"+p.id+"'><h4>"+p.name+"</h4><img src='"+p.path+"'></a>");
                            <?php endif; ?>
                        }
                        
                        
                        }
                        
                    
                };
                btn.disabled = true;
                xhttp.open("GET", "products.php?category="+category+"&admin="+admin+"&min_price="+min_price+"&max_price="+max_price+"&search="+search+"", true);
                xhttp.send();
               
            }
        function sure(){
            return(confirm('Etes-vous sûr de vouloir supprimer ce produit?'));

        }
        
         
        
        
        </script>
    </head>
    <body>
        <div id="container">
            <?php include "header.html" ?>   
            <?php include($menu) ?>
            <h2>Listing des produits</h2>
            <section class="main-container">  
               
                <div class="filtre">
                    <div class="filtre-block">
                        <label>Catégorie</label>
                        <select id="category" name="category">
                            <option value="Tout">Tout</option>
                            <?php foreach($allcategories as $category) : ?>
                            <option value="<?=$category['title']?>"><?=$category['title']?></option>
                            <?php endforeach; ?>  
                        </select>
                    </div>
                    <div class="filtre-block">
                        <label>Prix minimum</label>
                        <input type="number" id="min_price" min="1"   value="<?=$prixMin?>" name="min_price" onchange="verify_prices()">
                       
                    </div>
                    <div class="filtre-block">
                        <label>Prix maximum</label>
                        <input type="number" id="max_price" min="1"   value="<?=$prixMax?>"  name="max_price" onchange="verify_prices()">
                      
                    </div>
                    <div class="filtre-block">
                        <label>Recherche</label>
                        <input id="search" type="text" name="search">
                    </div>
                    <div class="filtre-block">
                        <input id="btn" type="button" onclick="load_products()" value="Filtrer">
                    </div>
                   
                    <div>
                        <p id="errorValues"></p>
                    </div>
                   
                </div>
                
                
                <div id="list">
                    
                </div>
</section>
            <?php include("footer.html"); ?>
        </div>
    </body>
</html>