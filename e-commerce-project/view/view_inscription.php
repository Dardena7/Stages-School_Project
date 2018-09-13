<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <base href="<?= $web_root ?>"/>
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/inscription.css" rel="stylesheet" type="text/css"/> 
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
            
//            
//             $.validator.addMethod('phone', function (value, element) {
//             return this.optional(element) || /^\d{3}-\d{3}-\d{4}$/.test(value);
//                    }, "Please enter a valid phone number");


            $(function () {

               $('#form').validate({
                   rules: {
                        lastname: {
                           required: true,
                           minlength: 3,
                           regex: /^[A-zÀ-ÿ' \- \s \é \è \ê \î \ï]+$/
                       },
                       firstname: {
                           required: true,
                           minlength: 3,
                           regex: /^[A-zÀ-ÿ' \- \s \é \è \ê \î \ï]+$/
                       },
                       birthday: {
                           required: true,
                           date:true           
                       },
                       email: {
                           required: true,
                           email:true
                       },
                       pseudo: {
                           required: true,
                           rangelength: [3,16],                 
                           regex: /^[A-zÀ-ÿ'0-9\- \s \é \è \ê \î \ï]+$/
                       },
                       password: {
                    required: true,
                    rangelength: [8,16]
                    },
                    
                    NN: {
                      required: true,
                      minlength: 11,
                      maxlength: 11
                    },
                
                
                password_confirm:{
                    required: true,
                    rangelength: [8,16], 
                    equalTo: "#password"     
                },
                       phone:{
                           required: true,
                           phone:true,
                           minlength: 9
                       }
                   },
                   messages: {
                       lastname: {
                           required: 'lastname is required',
                           minlength: 'minimum 3 caractères'

                       },
                       firstname: {
                           required: 'firstname is required',
                           minlength: 'minimum 3 caractères'

                       },
                       birthday:{
                           date: 'Invalid format'                     
                       },
                       email: {
                           required: 'email is required',
                           email: 'Invalid format'
                       },
                       pseudo: {
                           required: 'pseudo is required',
                           rangelength: 'Please choose a pseudo with 8-16 character'
                       },
                       password: {
                           required: 'password is required',
                           rangelength: 'Please choose a password with 8-16 character'

                       },
                       password_confirm: {
                           required:'password confirmation is required',
                           equalTo: 'Both password must be equals'
                       },
                       phone:{
                           minlength: 'This phone number is invalid',
                           digits: 'Input invalid'
                       },
                       
                       NN:{
                           required: 'Numéro National is required',
                           
                       }

                   }

               });
               $("input:text:first").focus();
           });

            function sure(){
                return(confirm('Etes-vous sûr de vouloir valider?'));
            }
        </script>
    </head>
    
    <body>
        <?php include "header.html"; ?>  
        <?php include $menu ?>
        
        <h2>Inscription</h2>
        <section class="main-container">
            <form id="form" action="login/inscription" method="post">               
                <p>
                    <label>Nom :</label>
                    <input id="lastname" name="lastname" type="text" />
                </p>                    
                <p>
                    <label>Prenom :</label>
                    <input id="firstname" name="firstname" type="text" />
                </p>

                <p>
                    <label>Date de Naissance :</label>
                    <input id="birthday" name="birthday" type="date" />
                </p>    

                <p>
                    <label>Pseudo :</label>
                    <input id="pseudo" name="pseudo" type="text" />
                </p>                    
                <p>
                    <label>Mot de passe :</label>
                    <input id="password" name="password" type="password" />
                </p>
                <p>
                    <label>Confirmer mot de passe :</label>
                    <input id="password_confirm" name="password_confirm" type="password" />
                </p>

                <p>
                    <label>Email :</label>
                    <input id="email" name="email" type="mail" />
                </p>  

                <p>
                    <label>Télephone :</label>
                    <input id="phone" name="phone" type="text" />
                </p>
                
                <p>
                    <label>Numéro National :</label>
                    <input id="NN" name="NN" type="text" />
                </p>
                
                <p>
                    <input class="send" type="submit" value="Valider" onclick="sure();"/>
                </p>
            </form>
            <?php if(count($errors)!=0): ?>
                <div class='errors'>
                    <br><br><p>Please correct the following error(s) :</p>
                    <ul>
                    <?php foreach($errors as $error): ?>
                        <li><?= $error ?></li>
                    <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>
        </section>   
            
        <?php include("footer.html"); ?>
        </div>
    </body>    
</html>
