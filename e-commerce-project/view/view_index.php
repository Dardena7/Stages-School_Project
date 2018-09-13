<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <base href="<?= $web_root ?>"/>
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/index.css" rel="stylesheet" type="text/css"/>
        
    </head>
    <body>
        <?php include 'header.html'; ?>
        <?php include $menu; ?>
        
        <h2>Accueil</h2>

        <section class="main-container">
            <p>Bienvenue sur Amazon-Like Shop, un site réalisé par Alexis Dardenne, Mohamed El Abdelkhalki et Benjamin D'Andrea.</p>
            <p>Vous pouvez consulter notre catalogue et faire vos achats en ligne en vous inscrivant préalablement.</p>
            <p>Bonne navigation sur notre site internet !</p>
            <img src="pictures/accueil-logo.jpg" />
        </section>
        
        <?php include 'footer.html'; ?>
</html>
