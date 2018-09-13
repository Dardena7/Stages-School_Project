<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <base href="<?= $web_root ?>"/>
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/categories.css" rel="stylesheet" type="text/css"/>
        
    </head>
    <body>
        <?php include 'header.html'; ?>
        <?php include $menu; ?>
        
        <h2>Liste des catégories</h2>

        <section class="main-container">
            <form class="addCategory" action="category/addCategory" method="post">
                <p>
                    <label>Ajouter une nouvelle catégorie</label>
                    <input type="text" name="newCategory"/>
                </p>
                <p>
                    <input class="send" type="submit" value="Ajouter" />
                </p>
            </form>
            <div class="errors">
                <p><?= $error ?></p>
            </div>
            <div class="success">
                <p><?= $success ?></p>
            </div>
            
            <?php foreach($categories as $cat): ?>
                <div class="categories">
                    <form action="category/modify_category" method="post" >
                        <input type="text" name="newCategory" value="<?= $cat['title'] ?>"/>
                        <input type="hidden" name="category_id" value="<?=$cat['id']?>" />
                        <input class="send" type="submit" value="Modifier"/>
                    </form>
                        <?php if($cat['deleted']): ?>
                        <a class="restore" href="category/restore_category/<?= $cat['id'] ?>">Restaurer</a>
                        <?php else: ?>
                        <a class="delete" href="category/delete_category/<?= $cat['id'] ?>">Supprimer</a>
                        <?php endif; ?>
                </div>
            <?php endforeach; ?>
        </section>
        
        <?php include 'footer.html'; ?>
</html>