<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <base href="<?= $web_root ?>"/>
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/login.css" rel="stylesheet" type="text/css"/>
        <script src="lib/jquery-2.2.0.min.js" type="text/javascript"></script>
        <script src="lib/jquery-validation-1.14.0/jquery.validate.js" type="text/javascript"></script>
       
    </head>
    <body>
        <?php include 'header.html'; ?>
        <?php include $menu; ?>
        <h2>Connexion</h2>
        <section class='main-container'>
            <form id="login" action="login/login" method="post">
                <p>
                    <label>Pseudo :</label>
                    <input id="pseudo" name="pseudo" type="text" value="<?= $pseudo ?>">
                </p>
                <p>
                    <label>Password :</label>
                    <input id="password" name="password" type="password" value="<?= $password ?>">
                </p>
                <p>
                    <input class="send" type="submit" value="Log In">
                </p>
            </form>
            <?php if(count($errors)!=0): ?>
                <br><br>
                <div class='errors'>
                    <ul>
                    <?php foreach($errors as $error): ?>
                        <li><?= $error ?></li>
                    <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>
        </section>
        <?php include"footer.html"; ?>
    </body>
</html>
