<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <base href="<?= $web_root ?>"/>
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/members.css" rel="stylesheet" type="text/css"/>
        <link href="css/basket.css" rel="stylesheet" type="text/css"/>
        
        <script>
            var col, order, tab, total_basket, success;
            
            document.onreadystatechange = function () {
                if (document.readyState === 'complete') {
                    col = "price";
                    order = "ASC";
                    tab = document.getElementById("tab");
                    success = document.getElementById("success");
                    total_basket = document.getElementById("total");
                    refresh_basket(<?=$member_id?>);
                }
            };
            
            function change_sort_values(member_id, newCol, newOrder){
                col = newCol;
                order = newOrder;
                refresh_basket(member_id);
            }
            
            function purchase(member_id){
                var xhttp = new XMLHttpRequest();
                
                xhttp.onreadystatechange = function () {
                    if (xhttp.readyState === 4 && xhttp.status === 200) {
                        var result = xhttp.responseText;
                        success.innerHTML = result;
                        refresh_basket(member_id);
                    }   
                };
                xhttp.open("GET", "purchase.php?member_id="+member_id, true);
                xhttp.send();
            }
            
            function delete_basket(member_id){
                var xhttp = new XMLHttpRequest();
                
                xhttp.onreadystatechange = function () {
                    if (xhttp.readyState === 4 && xhttp.status === 200) {
                        console.log(xhttp.responseText);
                        refresh_basket(member_id);
                    }   
                };
                xhttp.open("GET", "delete_basket.php?member_id="+member_id, true);
                xhttp.send();
            }
            
            function delete_good(member_id, product_id){
                var xhttp = new XMLHttpRequest();
                
                xhttp.onreadystatechange = function () {
                    if (xhttp.readyState === 4 && xhttp.status === 200) {
                        var result = xhttp.responseText;
                        refresh_basket(member_id);
                    }   
                };
                xhttp.open("GET", "delete_good.php?member_id="+member_id+"&product_id="+product_id, true);
                xhttp.send();
            }
            
            function modify_quantity(field, member_id, product_id){
                var xhttp = new XMLHttpRequest();
                var newQuantity = field.value;
                xhttp.onreadystatechange = function () {
                    if (xhttp.readyState === 4 && xhttp.status === 200) {
                        success.innerHTML = xhttp.responseText;
                        refresh_basket(member_id);
                    }   
                };
                xhttp.open("GET", "modify_good.php?member_id="+member_id+"&product_id="+product_id+"&newQuantity="+newQuantity, true);
                xhttp.send();
            }
            
            function refresh_basket(member_id){
                var xhttp = new XMLHttpRequest();
                
                xhttp.onreadystatechange = function () {
                    if (xhttp.readyState === 4 && xhttp.status === 200) {
                        var obj = JSON.parse(xhttp.responseText);
                        tab.innerHTML = "";
                        var tBasket = 0;
                        for(var good of obj.basket){
                            tBasket += parseInt(good.total);
                            tab.innerHTML += "<tr><td><a href='product/productdescription/"+good.product_id+"'>"+good.name+"</a></td><td><input name='quantity' type='number' onchange='modify_quantity(this,"+good.member_id+","+good.product_id+")' value='"+good.quantity+"'/></td><td>"+good.price+"</td><td>"+good.total+"</td><td><button class='drop_good' onclick='delete_good("+good.member_id+","+good.product_id+")'>Retirer</button></td></tr>"
                        }
                        total_basket.innerHTML = tBasket.toString();
                    }   
                };
                xhttp.open("GET", "refresh_basket.php?member_id="+member_id+"&col="+col+"&order="+order, true);
                xhttp.send();
               
            }
            
        </script>
        
    </head>
    <body>
        <?php include 'header.html'; ?>
        <?php include $menu; ?>
        <p id="result"></p>
        <h2>Panier de <?=$member->pseudo?></h2>

        <section class="main-container">
            <div class="table-container">
                <p id="result"></p>
                <table>
                    <thead> 
                        <tr>
                            <th>Produit  <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'name','DESC')">&#x25B2;</button> <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'name','ASC')">&#x25BC;</button></th>
                            <th>Quantité  <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'good_quantity','DESC')">&#x25B2;</button> <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'good_quantity','ASC')">&#x25BC;</button></th>
                            <th>Prix à l'unité  <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'price','DESC')">&#x25B2;</button> <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'price','ASC')">&#x25BC;</button></th>
                            <th>Total  <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'total','DESC')">&#x25B2;</button> <button class="sort_button" onclick="change_sort_values(<?=$member_id?>,'total','ASC')">&#x25BC;</button></th>
                        </tr>
                    </thead>



                    <tbody id="tab">
                    </tbody>
                </table>
                <br>
                <button class="drop_good" onclick="delete_basket(<?=$member_id?>)">Vider le panier</button>
                <br><br>
                <p>Total: <span id="total"></span></p>
                <br>
                <button class="buy" onclick="purchase(<?=$member_id?>)">Procéder au paiement</button>
                <p id="success"></p>
            </div>
        </section>
        
        <?php include 'footer.html'; ?>
</html>


