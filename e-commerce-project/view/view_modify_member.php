<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <base href="<?= $web_root ?>"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/profile.css" rel="stylesheet" type="text/css"/>
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
    
        $('#profile').validate({
            rules: {
                lastname: {
                    required: false,
                    minlength: 3,
                    regex: /^[A-zÀ-ÿ' \- \s \é \è \ê \î \ï]+$/
                },
                firstname: {
                    required: false,
                    minlength: 3,
                    regex: /^[A-zÀ-ÿ' \- \s \é \è \ê \î \ï]+$/
                },
                birthday: {
                    required: false,
                    date:true           
                },
                email: {
                    required: false,
                    email:true
                },
                password: {
                    required: true,
                    rangelength: [8,16]
                },
                password_confirm:{
                    required: true,
                    rangelength: [8,16], 
                    equalTo: "#password"     
                },
                
                phone:{
                    required: false,
                    digits: true,
                    minlength: 9
                }
            },
            messages: {
                lastname: {
                
                    minlength: 'minimum 3 caractères'
                   
                },
                firstname: {
                 
                    minlength: 'minimum 3 caractères'
                   
                },
                birthday:{
                    date: 'Invalid format'                     
                },
                email: {
                 
                    email: 'Invalid format'
                },
                password: {
                 
                    rangelength: 'please choose a password between 8-16 character'
                    
                },
                password_confirm: {
                    
                    equalTo: 'Both password must be equals'
                },
                phone:{
                    minlength: 'This phone number is invalid',
                    digits: 'Input invalid'
                }
                
            }
           
        });
        $("input:text:first").focus();
    });

        function sure(){
                  return(confirm('Etes-vous sûr de vouloir apporter ces modifications?'));
        }
    </script>
    </head>
    <body>  
        <?php include "header.html" ?>
        <?php include($menu) ?>
        <h2>Profil de <?= $member->pseudo  ?></h2>
        <section class="main-container">
            <form id="profile" action="member/modify_member/<?= $member->pseudo ?>" method="post">
                    <p>
                        <label>Nom :</label>
                        <input id="lastname" name="lastname" type="text" value="<?= $member->lastname ?>"/>
                    </p>                    
                    <p>
                        <label>Prenom :</label>
                        <input id="firstname" name="firstname" type="text" value="<?= $member->firstname ?>"/>
                    </p>

                    <p>
                        <label>Date de Naissance :</label>
                        <input id="birthday" name="birthday" type="date" value="<?= $member->birthday ?>"/>
                    </p>                                      
                    <p>
                        <label>Email :</label>
                        <input id="email" name="email" type="mail" value="<?= $member->email ?>"/>
                    </p>  

                    <p>
                        <label>Télephone :</label>
                        <input id="phone" name="phone" type="text" value="<?= $member->phone ?>"/>
                    </p>
                    <p>
                        <label>Changer mot de passe :</label>
                        <input id="password" name="password" type="password" value="" />
                    </p>
                    <p>
                        <label>Confirmer mot de passe :</label>
                        <input id="password_confirm" name="password_confirm" type="password" value="" />
                    </p>
                <p>
                    <input class="send" type="submit" value="Modifier" onclick="sure();"/>
                    <input class="send" type="reset" value="Reset"/>
                </p>
            </form>
            <!--<a class="delete-account" href="member/delete_account" >Supprimer votre compte</a>-->
            <?php if(count($errors)!=0): ?>
                <div class='errors'>
                    <br><br><p>La modification a échoué en raison de ces erreurs :</p>
                    <ul>
                    <?php foreach($errors as $error): ?>
                        <li><?= $error ?></li>
                    <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>
            <?php if(count($success)!=0): ?>
                <br><br><p>Les modifications suivantes on été réalisées :</p>
                <ul>
                    <?php foreach($success as $success): ?>
                        <li><?= $success ?></li>
                    <?php endforeach; ?>
                </ul>
            <?php endif; ?>
        </section>
        <?php include("footer.html"); ?>
        
    </body>
</html>

