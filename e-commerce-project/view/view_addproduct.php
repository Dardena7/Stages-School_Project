<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <base href="<?= $web_root ?>"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/addproduct.css" rel="stylesheet" type="text/css"/>
       <script src="lib/jquery-2.2.0.min.js" type="text/javascript"></script>
        <script src="lib/jquery-validation-1.14.0/jquery.validate.js" type="text/javascript"></script>
        <script>
            
            
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
                    rangelength: [3,30],    
                    regex: /[A-zÀ-ÿ'0-9\- \s \é \è \ê \î \ï]+$/,
                    required: true
                    
  
                },

                description: {
                    rangelength: [10,200],
                    regex : /[A-zÀ-ÿ'0-9\- \s \é \è \ê \î \ï]+$/,
                    required: true   
                },
                price: {
                    required: true,
                    min: 0.01,
                    number:true
                  
                },
                quantity: {
                    required: true,
                    min: 1,
                    digits: true
                }
                   
            },
            messages: {
                name: {
                    required: 'name required',
                    rangelength: 'please choose a name with 3-30 character'
                   
                },

                description: {
                    required: 'Description required',
                    rangelength: 'please choose a description with 10-200 character'
                   
                },
                price: {
                    required: 'Price required',
                    min: 'Not enought',
                    digit: 'Only numbers'
                },
                quantity: {
                    required: 'quantity required',
                    min: 'No stock at all' 
                }
                
            }
           
        });
        
        
        $("input:text:first").focus();
    });
        
        function verifyFile()
        {
            
            
            
        }
        
        function sure(){
            return(confirm('Etes-vous sûr de vouloir valider?'));
        }
        
        </script>
    </head>
    
    <body>
        
        <?php include 'header.html' ?>
        <?php include $menu ?>
        
        <h2>Ajouter un produit</h2>
        <section class="main-container">
            <form id="form" action="product/addproduct" method="post" enctype='multipart/form-data'>
                    <p>
                        <label>Nom :</label>
                        <input id="name" name="name" type="text"/>
                    </p>
                    <p>
                        <label>Catégorie :</label>
                        <select id="category" name="category">
                            <option value="Aucune">Aucune</option>
                            <?php foreach($categories as $category) : ?>
                            <option value="<?=$category['title']?>"><?=$category['title']?></option>
                            <?php endforeach; ?>  
                        </select>
                    </p> 
                    <p>
                        <label>Description :</label>
                        <textarea id="description" name="description" type="text" cols="40" rows="10"></textarea>
                    </p>
                    <p>
                        <label>Prix :</label>
                        <input id="price" name="price" type="number"/>
                    </p>                                      
                    <p>
                        <label>Quantité disponible :</label>
                        <input id="quantity" name="quantity" type="number"/>
                    </p>
                    <p>
                        <label>Photo :</label>
                        <input id="picture" name="picture" type="file" onchange="verifyFile(this);"/>
                    </p> 
                    <p>
                        <input class="send" type="submit" value="Valider" onclick="sure();"/>
                        <input class="send" type="reset" value="Reset"/>
                    </p>
            </form>
            <?php if($errors): ?>
                <div class='errors'><br><br><?= $errors ?></div>
            <?php endif; ?>
            <?php if($success): ?>
                <div class='errors'><br><br><?= $success ?></div>
            <?php endif; ?>
        </section>
        
        <?php include("footer.html"); ?>
    </body>
</html>

