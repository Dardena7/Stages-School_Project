<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Welcom to our website</title>
        <base href="<?= $web_root ?>"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/new.css" rel="stylesheet" type="text/css"/>
        <link href="css/members.css" rel="stylesheet" type="text/css"/>
        <script>
            function sure(){
                return(confirm('Etes-vous sûr de vouloir supprimer ce membre?'));
            }
        </script>
    </head>
    
    <body>
        <?php include "header.html" ?>
        <?php include($menu) ?>
        
        <h2>Liste des Membres</h2>
        <section class="main-container">
            <div class="table-container">
                <table>
                    <thead> 
                        <tr>
                            <th>Pseudo</th>
                            <th>Nom</th>
                            <th>Prenom</th>
                            <th>Date de naissance</th>
                            <th>email</th>
                            <th>Suppression</th>
                            <th>Admin</th>
                        </tr>
                    </thead>



                    <tbody>
                        <?php foreach($members as $m): ?>
                        <tr>
                           <td><a class="pseudo" href="member/modify_member/<?= $m->pseudo ?>" ><?= $m->pseudo ?></a></td>

                           <td><?= $m->lastname ?></td>

                           <td><?= $m->firstname ?></td>

                           <td><?= $m->birthday?></td>

                           <td><?= $m->email ?></td>
                           
                           <?php if($m->deleted): ?>
                           <td class="admin"><a href="member/restore_member/<?=$m->pseudo?>" onclick="sure();">Restaurer</a></td>
                           
                           <?php else: ?>
                           <td class="admin"><a href="member/delete_member/<?=$m->pseudo?>" onclick="sure();">Supprimer</a></td>
                           
                           <?php endif; ?>
                           
                           <?php if($m->flag): ?>
                           <td class="admin"><a href="member/unset_admin/<?=$m->pseudo?>" onclick="sure();">Enlever admin</a></td>
                           
                           <?php else: ?>
                           <td class="admin"><a href="member/set_admin/<?=$m->pseudo?>" onclick="sure();">Rendre admin</a></td>
                           
                           <?php endif; ?>
                        </tr>
                        <?php endforeach;?>  
                    </tbody>
                </table>
            </div>
        </section>
        <?php include("footer.html"); ?>
    </body>
</html>