@charset "UTF-8";
@media screen and (max-width: 1280px) {
  body {
    max-width: 100%;
    margin: 0;
    padding: 0;
  }

  #conteneur-ohmyfood {
    margin: 0 auto;
    padding: 0;
  }

  .prochainement {
    width: 30%;
    margin: 20px auto 0;
  }

  footer {
    max-width: 100%;
  }
}
@media screen and (max-width: 767px) {
  body {
    width: 100%;
  }

  #conteneur-ohmyfood .menu {
    width: 50%;
    text-align: center;
    display: flex;
    box-shadow: 0 0 4px 4px #ddd;
    text-decoration: none;
  }

  #conteneur-note-enchantee {
    margin: 20px auto 100px;
  }
}
body {
  background-color: #ddd;
  text-align: center;
  margin: 0;
  padding: 0;
}

h1 {
  font-family: Roboto, cursive, serif;
  background-color: #569C87;
  color: #F5C74A;
  font-size: 46px;
  margin: 0;
  padding: 26px;
  text-align: center;
}

h2 {
  background-color: #fff5fe;
}

header {
  left: 0;
  right: 0;
  display: inline-block;
  position: fixed;
  width: 700px;
  margin: 0 auto;
  text-align: center;
}

#plat-chic-fr {
  background-color: #ddd;
  text-align: center;
  margin: 0;
  padding: 0;
}

footer {
  background-color: #569C87;
  bottom: 0;
  left: 0;
  right: 0;
  display: inline-block;
  position: fixed;
  max-width: 700px;
  margin: 0 auto;
  text-align: center;
}
footer a {
  font-family: Roboto, cursive, serif;
  font-size: 20px;
  color: #F5C74A;
  text-decoration: none;
}
footer a:first-child {
  float: left;
  padding: 20px 0px 0 25px;
}
footer a:hover {
  animation: shake 0.82s cubic-bezier(0.36, 0.07, 0.19, 0.97) both;
  transform: translate3d(0, 0, 0);
  backface-visibility: hidden;
  perspective: 1000px;
}

#conteneur-chic-fr {
  margin: 20px auto 100px;
}

.plat {
  background-color: #FFF5FE;
  padding: 20px 0 30px 0;
}

.titre-plat h3 {
  font-family: Kalam, cursive, serif;
  font-size: 40px;
  padding: 30px 0 30px 0;
  margin: 10px 0 10px 0;
  background: -webkit-linear-gradient(180deg, #915DF6, #D37D22);
  background-clip: text;
  -webkit-background-clip: text;
  color: transparent;
}

h3 {
  font-family: Kalam, cursive, serif;
  font-size: 20px;
  color: #3D1319;
  padding: 5px 0 5px 0;
}
h3 .titre-plat {
  font-family: Kalam, cursive, serif;
  font-size: 40px;
  padding: 30px 0 30px 0;
  margin: 10px 0 10px 0;
  background: -webkit-linear-gradient(180deg, #915DF6, #D37D22);
  background-clip: text;
  -webkit-background-clip: text;
  color: transparent;
}

.categorie-entree h3 {
  color: #C8781A;
}

.categorie-plat h3 {
  color: #B580AB;
}

.categorie-dessert h3 {
  color: #9B80DB;
}

.categorie-entree ul {
  color: #C8781A;
}

.categorie-plat ul {
  color: #AE77A4;
}

.categorie-dessert ul {
  color: #9B81DB;
}

ul {
  font-size: 18px;
  list-style-type: none;
  text-align: center;
  margin: 10px 10px 30px 10px;
}

ul li {
  margin-bottom: 15px;
  text-align: center;
}

.prix {
  float: right;
}

/*........ Plat chic à la française ...............*/
.categorie-entree, h3 {
  color: #CA7D22;
}

ul {
  font-size: 18px;
  list-style-type: none;
  margin-top: 15px;
  padding: 0px 30px 30px;
}
ul li {
  margin-bottom: 10px;
  text-align: left;
}

.prix {
  float: right;
}

#plat-chic-fr {
  background-color: #ddd;
  max-width: 700px;
  margin: 0 auto;
  padding-bottom: 40px;
  text-align: center;
}

.plat h3 {
  font-size: 20px;
  padding-bottom: 0px;
  margin-bottom: 0;
}

hr {
  width: 50px;
  height: 2px;
  display: inline-block;
}

/*# sourceMappingURL=chic_fr.cs.map */
