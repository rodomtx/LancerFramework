<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Templeate_LIN.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   <head>
    <link rel="icon" type="image/png" href="/images/DB_16х16.png">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="description" content="LancerMex Framework">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>LancerMex Framework</title>

    <!-- Add to homescreen for Chrome on Android -->
    <meta name="mobile-web-app-capable" content="yes">


    <!-- Add to homescreen for Safari on iOS -->
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="apple-mobile-web-app-status-bar-style" content="black">
    <meta name="apple-mobile-web-app-title" content="LancerMex Framework">


    <!-- Tile icon for Win8 (144x144 + tile color) -->
    <meta name="msapplication-TileImage" content="images/touch/ms-touch-icon-144x144-precomposed.png">
    <meta name="msapplication-TileColor" content="#3372DF">

    <link href='https://fonts.googleapis.com/css?family=Roboto:400,500,300,100,700,900' rel='stylesheet'
          type='text/css'>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <!-- inject:css -->
    <link rel="stylesheet" href="/css/lib/getmdl-select.min.css">
    <link rel="stylesheet" href="/css/lib/nv.d3.min.css">
    <link rel="stylesheet" href="/css/application.min.css">
    <!-- endinject -->


</head>
<body>
<form action="#" class="form" runat="server">
<div class="mdl-layout mdl-js-layout color--gray is-small-screen login">
    <main class="mdl-layout__content">
        <div class="mdl-card mdl-card__login mdl-shadow--2dp" >
        <div class="mdl-card__supporting-text color--dark-gray">
            <div class="mdl-grid">
                <div class="mdl-cell mdl-cell--12-col mdl-cell--4-col-phone">
                    <span class="mdl-card__title-text text-color--smooth-gray">Lancer Framework</span>
                </div>
                <div class="mdl-cell mdl-cell--12-col mdl-cell--4-col-phone">
                    <span class="login-name text-color--white">Sign up</span>
                </div>
                <div class="mdl-cell mdl-cell--12-col mdl-cell--4-col-phone">
                    <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label full-size">
                        <input class="mdl-textfield__input" type="text" id="name" runat="server">
                        <label class="mdl-textfield__label" for="name">Name</label>
                    </div>
                    <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label full-size">
                        <input class="mdl-textfield__input" type="password" id="password" runat="server">
                        <label class="mdl-textfield__label" for="password">Password</label>
                    </div>
                    <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label full-size">
                        <input class="mdl-textfield__input" type="text" id="email" runat="server">
                        <label class="mdl-textfield__label" for="e-mail">Email</label>
                    </div>
                </div>
                <div class="mdl-cell mdl-cell--12-col mdl-cell--4-col-phone submit-cell">
                    <a href="/Default.aspx" class="login-link">I have already signed up</a>
                    <div class="mdl-layout-spacer"></div>
                        <asp:Button id="submit" class="mdl-button mdl-js-button mdl-button--raised color--light-blue" runat="server" OnClick="signupService" Text="SIGN UP" />  
                   </div>
            <div id="mensajes" class="mdl-card mdl-card__login mdl-shadow--2dp" runat="server"></div>
        
            </div>
        </div>
    </div>
    </main>
</div>
</form>
<!-- inject:js -->
<script src="js/d3.min.js"></script>
<script src="js/getmdl-select.min.js"></script>
<script src="js/material.min.js"></script>
<script src="js/nv.d3.min.js"></script>
<script src="js/layout/layout.min.js"></script>
<script src="js/scroll/scroll.min.js"></script>
<script src="js/widgets/charts/discreteBarChart.min.js"></script>
<script src="js/widgets/charts/linePlusBarChart.min.js"></script>
<script src="js/widgets/charts/stackedBarChart.min.js"></script>
<script src="js/widgets/employer-form/employer-form.min.js"></script>
<script src="js/widgets/line-chart/line-charts-nvd3.min.js"></script>
<script src="js/widgets/map/maps.min.js"></script>
<script src="js/widgets/pie-chart/pie-charts-nvd3.min.js"></script>
<script src="js/widgets/table/table.min.js"></script>
<script src="js/widgets/todo/todo.min.js"></script>
<!-- endinject -->

</body>
</html>