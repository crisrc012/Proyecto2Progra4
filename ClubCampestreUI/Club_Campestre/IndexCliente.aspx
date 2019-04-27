<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="IndexCliente.aspx.cs" Inherits="Club_Campestre.IndexCliente" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <!-- One -->
    <section class="banner style5 orient-left content-align-left image-position-right fullscreen onload-image-fade-in onload-content-fade-right">
        <div class="content">
            <h1>Club La Libertad</h1>
            <p class="major">Club Campestre de montaña inspirado en los bosques humedos de Costa Rica, afiliado a <a href="https://www.ict.go.cr/es/">ICT</a> y es producto de <a href="https://www.visitcostarica.com/es">Esencial Costa Rica</a>.</p>
            <ul class="actions stacked">
                <li><a href="#first" class="button big wide smooth-scroll-middle">Comenzar</a></li>
            </ul>
        </div>
        <div class="image">
            <img src="images/banner2.JPG" alt="" />
        </div>
        <%--Login--%>
        <div id="id01" class="modal">
            <div class="modal-content animate" action="/action_page.php" runat="server">
                <div class="imgcontainer">
                    <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
                    <img src="Images/Users-icon.png" alt="Avatar" class="avatar" />
                </div>
                <div class="container">
                    <label for="uname"><b>Identificación</b></label>
                    <input type="text" id="uname" placeholder="Digite su identificación" name="uname" required="required" runat="server" />
                    <label for="psw"><b>Contraseña</b></label>
                    <input type="password" id="psw" placeholder="Digite su contraseña" name="psw" required="required" runat="server" />
                    <button type="submit" onserverclick="IniciarSesion" runat="server">Iniciar Sesión</button>
                </div>
                <div class="container" style="background-color: #f1f1f1">
                    <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancelar</button>
                </div>
            </div>
        </div>
    </section>

    <!-- Two -->
    <section class="spotlight style2 orient-right content-align-left image-position-center onscroll-image-fade-in" id="first">
        <div class="content">
            <h2>Socios o Visitantes del Club</h2>
            <p>Nuestros socios gozan de membresias anuales que les permiten disfrutar de todas las atracciones y luegos que brinda nuestro Club de Montaña La Libertad. Puede Registrarse como un cliente nuestro y tener acceso de adquirir alguna de nuestras membresias o incluso reservar alguno de nuestros bastos servios de primera calidad.</p>
            <ul class="actions stacked">
                <li><a href="RegistroCliente.aspx" class="button">Registrarse</a></li>
            </ul>
        </div>
        <div class="image">
            <img src="images/Entrada.jpeg" alt="" />
        </div>
    </section>

    <!-- Three -->
    <section class="spotlight style2 orient-left content-align-left image-position-center onscroll-image-fade-in">
        <div class="content">
            <h2>Membresias</h2>
            <p>Para nuestros socios ofrecemos Membresias anuales que contienen distintos servicios incluidos ademas de ofrecer descuentos atractivos en los restaurantes del Club. Las tarifas son competitivas y se ajustan a todo tipo de cliente que valora la naturaleza y los lujos que ella ofrece...</p>
            <ul class="actions stacked">
                <li><a href="MembresiaCliente.aspx" class="button">Membresias</a></li>
            </ul>
        </div>
        <div class="image">
            <img src="Images/1-434x434.jpg" alt="" />
        </div>

    </section>

    <!-- Four -->
    <%--  <section class="spotlight style1 orient-right content-align-left image-position-center onscroll-image-fade-in">
        <div class="content">
            <h2>Servicios</h2>
            <p>Nuestros Club ofrece gran catidad de servicios para el disfrute de todos nuestros clientes; pueden gozar de varias piscinas, amplio gimnacio con spa y sauna, canchas para distintos deportes, cabañas, ranchos para fiestas o BBQ. O bien puede realizar reservaciones de cualquiera de nuestros centros de eventos o Caterine Service.</p>
            <ul class="actions stacked">
                <li><a href="#" class="button">Servicios</a></li>
            </ul>
        </div>
        <div class="image">
            <img src="images/Servicios.jpg" alt="" />
        </div>
    </section>--%>

    <!-- Five -->
    <section class="wrapper style1 align-center">
        <div class="inner">
            <h2>Amplias Instalaciones.</h2>
            <p>Nuestras instalaciones fueron certificadas con la bandera azul de proteccion del medio ambiente; nuestros jardines son cuidados con altos estandares de supervicion, cada uno de nuestros servicios son brindados por personal capacitado y con un excelente servicio al cliente..</p>
        </div>

        <!-- Gallery -->
        <div class="gallery style2 medium lightbox onscroll-fade-in">
            <article>
                <a href="Images/gallery/Peques/5.jpg" class="image">
                    <img src="Images/gallery/Peques/5.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Naturalez</h3>
                    <p>Grandes espacios de terreno con las mejores escenas naturales y comodidades necesarias para el disfrute familiar.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/6.jpg" class="image">
                    <img src="Images/gallery/Peques/6.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Naturaleza</h3>
                    <p>Grandes espacios de terreno con las mejores escenas naturales y comodidades necesarias para el disfrute familiar.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/7.jpg" class="image">
                    <img src="Images/gallery/Peques/7.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Naturaleza</h3>
                    <p>Grandes espacios de terreno con las mejores escenas naturales y comodidades necesarias para el disfrute familiar.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/8.jpg" class="image">
                    <img src="Images/gallery/Peques/8.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Piscinas</h3>
                    <p>Amplias piscinas al aire libre y bajo techo, temperadas.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/9.jpg" class="image">
                    <img src="Images/gallery/Peques/9.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Piscinas</h3>
                    <p>Amplias piscinas al aire libre y bajo techo, temperadas.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/10.jpg" class="image">
                    <img src="Images/gallery/Peques/10.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Cabañas</h3>
                    <p>Cabañas con todas las comodidades necesarias para el disfrute de la naturaleza.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/11.jpg" class="image">
                    <img src="Images/gallery/Peques/11.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Cabañas</h3>
                    <p>Cabañas con todas las comodidades necesarias para el disfrute de la naturaleza.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/12.jpg" class="image">
                    <img src="Images/gallery/Peques/12.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Restaurante</h3>
                    <p>Amplio Menu a la carta o buffet.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/13.jpg" class="image">
                    <img src="Images/gallery/Peques/13.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Restaurante</h3>
                    <p>Restaurante con lo mejor de las comidas mexinas.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/14.jpg" class="image">
                    <img src="Images/gallery/Peques/14.jpg"  alt="" />
                </a>
                <div class="caption">
                    <h3>Sauna</h3>
                    <p>Contamos con distintos tipos de saunas con diferentes ambientes.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
            <article>
                <a href="Images/gallery/Peques/15.jpg" class="image">
                    <img src="Images/gallery/Peques/15.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Saunas</h3>
                    <p>Contamos con distintos tipos de saunas con diferentes ambientes.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>
<%--            <article>
                <a href="images/gallery/fulls/12.jpg" class="image">
                    <img src="images/gallery/thumbs/12.jpg" alt="" />
                </a>
                <div class="caption">
                    <h3>Ipsum Dolor</h3>
                    <p>Lorem ipsum dolor amet, consectetur magna etiam elit. Etiam sed ultrices.</p>
                    <ul class="actions fixed">
                        <li><span class="button small">Details</span></li>
                    </ul>
                </div>
            </article>--%>
        </div>

    </section>

    <!-- Six -->
    <section class="wrapper style1 align-center">
        <div class="inner">
            <h2>Servicios que puede disfrutar...</h2>
            <p>Disfurte de nuestras zonas recreativas en compañia de su familia y amigos. Contamos con Cancha sintetica, agradables piscinas, canchas de voleibol, zona barbecue, gimnacion y todo lo necesario para un ambiente de relajacion y diversion.</p>
            <div class="items style1 medium onscroll-fade-in">
                <section>
                    <span class="icon style2 major fa-diamond"></span>
                    <h3>Membresia GOLD</h3>
                    <p>Membresia Anual para todos los dias de la semana; con acceso ilimitado a todos nuestros servicios incluyendo servicio buffet en nuestro Restaurante MataBurros Mexican Food y Spa.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-save"></span>
                    <h3>Membresia SILVER</h3>
                    <p>Membresia Anual para cuatro los dias de la semana incluyendo fines de semana; con acceso ilimitado a todos nuestros servicios incluyendo servicio buffet en nuestro Restaurante MataBurros Mexican Food.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-bar-chart"></span>
                    <h3>Membresia BRONZE</h3>
                    <p>Membresia Anual para cuatro los dias de la semana; con acceso ilimitado a todas las zonas recreativas y descuentos en el restaurante.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-wifi"></span>
                    <h3>Piscina</h3>
                    <p>Dentro de nuestras instalaciones se encuentras refrescantes piscinas, incluyento una olimpica con servicio de salvavidas e instrutor de natacion.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-cog"></span>
                    <h3>Cabañas</h3>
                    <p> Todas nuestras Cabañas se encuentran equipadas con minicocina, television po cable, agua caliente y una pequeña terraza para su descanso y comodidad en su estadia.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-paper-plane"></span>
                    <h3>Ranchos para fiestas BBQ</h3>
                    <p>Tenemos disponibles veinte ranchos de distintos tamaños con su propia parrilla y refrigeradora al aire libre rodeado de naturales.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-desktop"></span>
                    <h3>Gimnasio</h3>
                    <p>Maquinaria con lo utlimo en tecnologia para su entrenamiento, contamos con equipo de mediciones e instructores que le ayudaran a cumplir sus metas.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-refresh"></span>
                    <h3>Canchas</h3>
                    <p>Tenemos tres canchas para actividades deportivas variadas como voleibol, tenis, futbol y basquetball</p>
                </section>
                <section>
                    <span class="icon style2 major fa-hashtag"></span>
                    <h3>Restarurante Mataburros</h3>
                    <p>Le ofrecemos un amplio menu con especialidades al estilo mexicano, nuestro chef se encargara de darle a su paladar una experiencia unica.</p>
                </section>
                <%--<section>
                    <span class="icon style2 major fa-bolt"></span>
                    <h3>Turpis</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi dui turpis, cursus eget orci amet aliquam congue semper. Etiam eget ultrices risus nec tempor elit.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-envelope"></span>
                    <h3>Ultrices</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi dui turpis, cursus eget orci amet aliquam congue semper. Etiam eget ultrices risus nec tempor elit.</p>
                </section>
                <section>
                    <span class="icon style2 major fa-leaf"></span>
                    <h3>Risus</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi dui turpis, cursus eget orci amet aliquam congue semper. Etiam eget ultrices risus nec tempor elit.</p>
                </section>--%>
            </div>
        </div>
    </section>

    <!-- Seven -->
    <section class="wrapper style1 align-center">
        <div class="inner medium">
            <h2>Sugerencia Escribanos</h2>
            <div method="post" action="#" runat="server">
                <div class="fields">
                    <div class="field half">
                        <label for="name">Nombre</label>
                        <input type="text" name="name" id="name" value="" />
                    </div>
                    <div class="field half">
                        <label for="email">Email</label>
                        <input type="email" name="email" id="email" value="" />
                    </div>
                    <div class="field">
                        <label for="message">Mensaje</label>
                        <textarea name="message" id="message" rows="6"></textarea>
                    </div>
                </div>
                <ul class="actions special">
                    <li>
                        <input type="submit" name="submit" id="submit" value="Enviar Mensaje" /></li>
                </ul>
            </div>
        </div>
    </section>

    <!-- Footer -->
    <footer class="wrapper style1 align-center">
        <div class="inner">
            <ul class="icons">
                <li><a href="#" class="icon style2 fa-twitter"><span class="label">Twitter</span></a></li>
                <li><a href="#" class="icon style2 fa-facebook"><span class="label">Facebook</span></a></li>
                <li><a href="#" class="icon style2 fa-instagram"><span class="label">Instagram</span></a></li>
                <li><a href="#" class="icon style2 fa-linkedin"><span class="label">LinkedIn</span></a></li>
                <li><a href="#" class="icon style2 fa-envelope"><span class="label">Email</span></a></li>
            </ul>
            <p>&copy; Untitled. Design: <a href="#">HTML5 UP</a>.</p>
        </div>
    </footer>
</asp:Content>
