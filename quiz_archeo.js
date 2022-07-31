/*
 Navicat Premium Data Transfer

 Source Server         : MongoArcheo
 Source Server Type    : MongoDB
 Source Server Version : 40022
 Source Host           : localhost:27017
 Source Schema         : archeo

 Target Server Type    : MongoDB
 Target Server Version : 40022
 File Encoding         : 65001

 Date: 31/07/2022 13:31:26
*/


// ----------------------------
// Collection structure for quiz_archeo
// ----------------------------
db.getCollection("quiz_archeo").drop();
db.createCollection("quiz_archeo");

// ----------------------------
// Documents of quiz_archeo
// ----------------------------
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e000095000694",
    id: "1",
    question: "Où le cercueil de Louise de Quengo a-t-il été retrouvé ?",
    "reponse_1": "Rennes",
    "reponse_2": "Paris",
    "reponse_3": "Anger",
    "reponse_4": "Matignon",
    "bonne_reponse": "1",
    Description: "Le site où a été retrouvé Louise de Quengo, le couvent des Jacobins à Rennes, est fouillé depuis 2011 par l’Inrap. Entre le XVème et le XVIIIème siècle, cet établissement religieux est devenu un important lieu de pèlerinage et d’inhumation. Ainsi, environ 800 sépultures y ont été mises au jour par les archéologues. Quatre autres cercueils de plomb, datés du XVIIe siècle, ont également été retrouvés. Ils étaient aussi accompagnés de reliquaires en forme de cœur."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e000095000695",
    id: "2",
    question: "A quel style appartient cette fresque romaine trouvée à Arles ?",
    "reponse_1": "Premier style",
    "reponse_2": "Style structural",
    "reponse_3": "Deuxième style Pompéin",
    "reponse_4": "Style à incrustation",
    "bonne_reponse": "3",
    Description: "Des fresques exceptionnelles de l’époque romaine ont été mises au jour à Arles en juillet dernier. Mettant en scène des personnages très finement travaillés, ces peintures murales ont dévoilé un style de représentation extrêmement rare. Une première campagne de fouilles avait révélé en 2014 dans une pièce associée à une chambre à coucher, un rare décor peint de deuxième style pompéien, daté entre 70 et 20 avant notre ère."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e000095000696",
    id: "3",
    question: "Qu'a-t-on retrouvé à la place des organes dans la momie retrouvée dans une statue bouddhiste ?",
    "reponse_1": "Des cailloux",
    "reponse_2": "Des rouleaux de papiers",
    "reponse_3": "Rien",
    "reponse_4": "De la paille",
    "bonne_reponse": "2",
    Description: "Selon le chercheur Erik Bruijn, spécialiste de l’art bouddhique, il pourrait s’agir de la momie de Liuquan, un célèbre maître bouddhiste de l’Ecole de méditation chinoise. La momie ne contenait aucun organe. Autre chose extraordinaire, des rouleaux de papiers recouverts d’anciens caractères chinois ont été identifiés lors de l’autopsie de la momie. Ils étaient placés là où se trouvaient autrefois les organes du défunt."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e000095000698",
    id: "4",
    question: "Combien de squelettes ont été retrouvés dans la tombe d’Amphipolis en Grèce ?",
    "reponse_1": "2",
    "reponse_2": "3",
    "reponse_3": "4",
    "reponse_4": "5",
    "bonne_reponse": "4",
    Description: "D’une dimension colossale (500 mètres de circonférence), la tombe repose sous un tumulus artificiel de 30 mètres de hauteur. Il serait le plus grand identifié en Asie mineure et se situait autrefois dans une importante cité grecque. Sous le tumulus, la sépulture est gardée par deux énormes sphinx et des cariatides (statues de femmes servant de colonnes) de plus de deux mètres de haut. Devant l’ampleur de cette tombe, la question de l’identité de son occupant s’est vite posée. Pourrait-il s’agir de la tombe d’Alexandre le Grand, de sa mère Olympias ou de son épouse Roxane ? La sépulture malheureusement pillée a dans l’ensemble livré peu d’indices. En janvier 2015, la découverte de cinq squelettes, quatre enterrés et un incinéré, ne fait qu’épaissir le mystère. Ont été identifiés le corps d’une femme de plus de 60 ans, d’un bébé et de deux hommes âgés entre 35 et 45 ans."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e000095000699",
    id: "5",
    question: "Qu'a-t-il été retrouvé dans une baie du Péloponnèse en Grèce en août 2015 ?",
    "reponse_1": "Une tombe",
    "reponse_2": "Un navire",
    "reponse_3": "Une cité fortifiée",
    "reponse_4": "Des squelettes de dinosaures",
    "bonne_reponse": "3",
    Description: "En août 2015, les vestiges d’une cité fortifiée de l’âge de Bronze sont mis au jour dans une baie du Péloponnèse en Grèce. Une importante découverte qui devrait permettre d’en savoir plus sur cette période de l’histoire de la Grèce. Ces vestiges reposaient sous l’eau, à 1 à 3 mètres de fond. Ils recouvraient une superficie d’au moins 1,2 hectare."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e00009500069a",
    id: "6",
    question: "Quel égyptologue a émis l'extraordinaire hypothèse que deux pièces inconnues pourraient se trouver dans le tombeau de Toutankhamon ?",
    "reponse_1": "Nicolas Reeves",
    "reponse_2": "Jean-François Champollion",
    "reponse_3": "James Peter Allen",
    "reponse_4": "Thomas George Allen",
    "bonne_reponse": "1",
    Description: "En août dernier, l’égyptologue Nicolas Reeves a émis une extraordinaire hypothèse : deux pièces inconnues pourraient se trouver dans le tombeau du célèbre pharaon de la XVIIIe dynastie. Selon l’archéologue, ces deux pièces pourraient abriter la sépulture de la reine Néfertiti, épouse du pharaon Akhénaton, père de Toutankhamon. Nicolas Reeves aurait en effet repéré sur des images de haute précision ainsi que sur des relevés 3D, des fissures et des tracés linéaires sous les couches de peintures du tombeau qui pourraient indiquer la présence de deux portes cachées."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e00009500069b",
    id: "7",
    question: "Combien de géoglyphes auraient été identifiés sur le plateau de Nazca au Pérou en 2015 ?",
    "reponse_1": "12",
    "reponse_2": "57",
    "reponse_3": "14",
    "reponse_4": "24",
    "bonne_reponse": "4",
    Description: "24 nouveaux géoglyphes auraient été identifiés sur le plateau de Nazca au Pérou, à 1,5 kilomètre au nord de la ville de Nazca.   Ces gigantesques dessins tracés sur le sol et visibles en hauteur ont été découverts par une équipe de chercheurs japonais. Selon ces derniers, ces nouvelles figures pourraient être antérieures (200-400 avant J.C.) aux célèbres géoglyphes de Nazca (400-650 après J.C.) inscrits au patrimoine mondial de l’Unesco."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e00009500069c",
    id: "8",
    question: "Vers quel année la civilisation étrusque commença à prospérer ?",
    "reponse_1": "600 avant J.C",
    "reponse_2": "900 avant J.C",
    "reponse_3": "200 après J.C",
    "reponse_4": "1200 avant J.C",
    "bonne_reponse": "2",
    Description: "La civilisation étrusque commença à prospérer vers 900 avant J.C. Elle domina une partie de l’Italie avant de progressivement décliner vers le Vème sicèle avant J.C. et d’être finalement absorbée par l’empire romain entre 300 et 100 avant notre ère."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e00009500069d",
    id: "9",
    question: "Combien de pierres ont été retrouvés Salisbury ?",
    "reponse_1": "54",
    "reponse_2": "30",
    "reponse_3": "120",
    "reponse_4": "90",
    "bonne_reponse": "4",
    Description: "En septembre 2015, les vestiges d’un autre monument mégalithique ont été mis au jour. En effet, 90 pierres couchées et enterrées sous un mètre de terre ont été découvertes à trois kilomètres du célèbre site de Stonehenge grâce à des techniques de prospection géophysique."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e00009500069e",
    id: "10",
    question: "De quel sexe est le defunt retrouvé dans une tombe princière celte en 2015 ?",
    "reponse_1": "Homme",
    "reponse_2": "Femme",
    "reponse_3": "Mi-femme et mi-homme",
    "reponse_4": "On ne sait pas encore",
    "bonne_reponse": "1",
    Description: "Quant à l’occupant de cette tombe, il s’agissait d’un individu richement paré de bijoux et dont le sexe n’avait pas encore pu être déterminé en raison du mauvais état de conservation des ossements. Depuis décembre, le voile est levé sur le sexe du défunt, il s’agissait d’un homme. Des analyses d’ADN pourront également être menées afin de déterminer de possibles filiations avec d’autres occupants de tombes, à l’exemple de deux sépultures de l’âge du fer qui pourraient potentiellement contenir des ancêtres de ce prince celte."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e00009500069f",
    id: "11",
    question: "Des pièces d'argents ont été trouvées à Blenstrup (Danemark). De quand sont-elles datées ?",
    "reponse_1": "L'an 200",
    "reponse_2": "L'an 500",
    "reponse_3": "L'an 800",
    "reponse_4": "L'an 1000",
    "bonne_reponse": "4",
    Description: "Un grand nombre de pièces d'argent ont fait leur apparition dans un champ labouré à Blenstrup. Les pièces en argent sont de l'époque des Vikings, datées environ de l'an 1000."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a0",
    id: "12",
    question: "Sous le regne de quel roi viking la forteresse de Borgring fut construite ?",
    "reponse_1": "Harlad aux Beaux Cheveux",
    "reponse_2": "Harald Wifi",
    "reponse_3": "Harald Bluetooth",
    "reponse_4": "Saint Olaf",
    "bonne_reponse": "3",
    Description: "Borgring mesure 144 mètres de diamètre. Construite en terre et en bois, elle possédait quatre portes. À l'intérieur, deux routes pavées de bois s'entrecroisaient pour y mener. La datation des cernes de bois indique que la forteresse aurait été érigée entre 970 et 980, soit à la même période que pour les autres qui ont été retrouvées. Il est vraisemblable que ce fut sous l'égide Harald \"Bluetooth\" Gormsson, qui régnait alors."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a1",
    id: "13",
    question: "À l’âge des Vikings, quel était la coutume d'enterrement des rois et des chefs ?",
    "reponse_1": "Ils sont jetés à la mer",
    "reponse_2": "ils sont enterrer à bord d'un bateau",
    "reponse_3": "Ils sont incinérés",
    "reponse_4": "Ils sont enterrer comme aujour'hui",
    "bonne_reponse": "2",
    Description: "À l’âge des Vikings au cours duquel ces guerriers et marchands d’Europe du Nord ont sillonné les mers entre les VIIIe et XIe siècles, il était de coutume d’enterrer les rois et les chefs à bord d’un bateau hissé à terre et enseveli sous un monticule."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a2",
    id: "14",
    question: "Où l'unique fossile de Spicomellus découvert à ce jour ?",
    "reponse_1": "Canada",
    "reponse_2": "Inde",
    "reponse_3": "Maroc",
    "reponse_4": "Péru",
    "bonne_reponse": "3",
    Description: "Au départ, le personnel du musée a attribué l'os au stégosaure marocain Adratiklit, car il provenait de la même région dans les montagnes de l'Atlas. Maidment et ses collègues ont toutefois rapidement réalisé que le fossile devait appartenir à une espèce nouvelle, ce qui le rendait d'autant plus important. Par la suite, le musée d'histoire naturelle s'est rapproché de l'université Sidi Mohamed Ben Abdellah de Fès, au Maroc, pour conclure un accord de collaboration dans l'étude du fossile."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a3",
    id: "15",
    question: "Comment est surnommé le plus grand dinosaure retrouvé en Australie ?",
    "reponse_1": "Cooper",
    "reponse_2": "Mississpi",
    "reponse_3": null,
    "reponse_4": null,
    "bonne_reponse": "1",
    Description: "Surnommé Cooper en référence à un ruisseau voisin, l'animal a vu ses fossiles retenus par la science pendant plus de dix ans, notamment pour une analyse tridimensionnelle de la surface des os. Les résultats de cette longue étude ont fait l'objet d'une publication en juin dans la revue PeerJ, confirmant que le dinosaure âgé de 95 millions d'années constitue bel et bien une nouvelle espèce : Australotitan cooperensis."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a4",
    id: "16",
    question: "Par quoi se distingue le Tlatolophus galorum ?",
    "reponse_1": "Sa manière de communiquer",
    "reponse_2": "Sa crête",
    "reponse_3": "Sa peau",
    "reponse_4": "Son alimentation",
    "bonne_reponse": "2",
    Description: "Tlatolophus galorum est un lambéosaure, une sous-famille de dinosaures herbivores. Son nom, il le doit à l'étonnante crête en forme de virgule qui orne son crâne, ou plus précisément à sa ressemblance avec le symbole aztèque tlahtolli, qui signifie « mot » en langue nahuatl."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a5",
    id: "17",
    question: "A quel espèce de dinosaure appartiennent le Ceratosuchops  et le Riparovenator ?",
    "reponse_1": "Lambéosaure",
    "reponse_2": "Limusaurus",
    "reponse_3": "Yamatosaurus",
    "reponse_4": "Spinosauridés",
    "bonne_reponse": "4",
    Description: "Présentés dans la revue Scientific Reports, les fossiles découverts sur l'île appartiennent à deux nouveaux types de spinosauridés, un groupe énigmatique de grands dinosaures prédateurs auquel appartenait notamment Spinosaurus, le célèbre « dinosaure nageur »."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a6",
    id: "18",
    question: "Où vivait le Stegouros elengassen ?",
    "reponse_1": "Sur les rivages de la Patagonie chilienne",
    "reponse_2": "Au brésil ",
    "reponse_3": "Au nord du mexique ",
    "reponse_4": "Au sud de l'Italie",
    "bonne_reponse": "1",
    Description: "Il y a plus de 72 millions d'années, les rivages de la Patagonie chilienne abritaient un solide petit dinosaure à la queue unique en son genre : une imposante masse osseuse à l'allure de batte aplatie et dentelée. « C'est absolument sans précédent, » déclarait Alexander Vargas, paléontologue à l'université du Chili, à propos de ladite queue."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a7",
    id: "19",
    question: "En quelle année le san José a-t-il fait naufrage ?",
    "reponse_1": "June 1508",
    "reponse_2": "June 1608",
    "reponse_3": "June 1708",
    "reponse_4": "June 1808",
    "bonne_reponse": "3",
    Description: "Enfin des nouvelles du San José, considéré aujourd'hui comme l'épave recelant le plus de trésors au monde. Depuis son naufrage en juin 1708 au large de Carthagène des Indes, dans les eaux claires de la péninsule de Baru, en Colombie, ce galion espagnol - ou du moins ce qu'il en reste - gît par 950 mètres de fond, une profondeur que seules des machines sont capables d'atteindre. Localisée en 2015, l'épave n'a jamais été intégralement fouillée."
} ]);
db.getCollection("quiz_archeo").insert([ {
    _id: "608ab356aa2e0000950006a8",
    id: "20",
    question: "A quel espèce de dinosaure appartient la patte fossilisé retrouvé à Tanis (Dakota) ?",
    "reponse_1": "Spinosauridés",
    "reponse_2": "Thescelosaurus",
    "reponse_3": "Lambéosaure",
    "reponse_4": "Yamatosaurus",
    "bonne_reponse": "2",
    Description: "Des paléontologues viennent de découvrir la patte d’un Thescelosaurus, un petit herbivore qui vivait en Amérique du Nord à la fin du Crétacé il y a 66 millions d’années. D’après eux, les restes fossilisés datent du jour où l’astéroïde massif a pu tuer le dinosaure en frappant la Terre à 3000 km de là où il se trouvait, dans ce qui est aujourd’hui le golfe du Mexique."
} ]);
