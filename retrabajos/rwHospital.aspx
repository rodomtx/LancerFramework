﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwHospital.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwHospital" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="mdl-grid ui-tables">

            
            <div class="mdl-cell mdl-cell--12-col-desktop mdl-cell--12-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h1 class="mdl-card__title-text">Hospital Inventory</h1>
                    </div>
                    <div class="mdl-card__supporting-text no-padding">
                        <table class="mdl-data-table mdl-js-data-table stripped-table">
                            <thead>
                            <tr>
                                <th class="mdl-data-table__cell--non-numeric">#</th>
                                <th class="mdl-data-table__cell--non-numeric">Book title</th>
                                <th class="mdl-data-table__cell--non-numeric">Author</th>
                                <th class="mdl-data-table__cell--non-numeric">Genre</th>
                                <th class="mdl-data-table__cell--non-numeric">Year</th>
                                <th class="mdl-data-table__cell--non-numeric">Originally published</th>
                                <th class="mdl-data-table__cell--non-numeric">Language</th>
                                <th class="mdl-data-table__cell--non-numeric">Original Language</th>
                                <th class="mdl-data-table__cell--non-numeric">Availability</th>
                                <th class="mdl-data-table__cell--non-numeric"> </th>
                            </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class="mdl-data-table__cell--non-numeric">5</td>
                                    <td class="mdl-data-table__cell--non-numeric">Life of Pi</td>
                                    <td class="mdl-data-table__cell--non-numeric">Yann Martel</td>
                                    <td class="mdl-data-table__cell--non-numeric"><span class="label label--mini color--green">Fiction</span> </td>
                                    <td class="mdl-data-table__cell--non-numeric">2016</td>
                                    <td class="mdl-data-table__cell--non-numeric">2001</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">
                                        <span class="label label--mini label__availability background-color--primary"></span>
                                        <span class="label label--mini label__availability background-color--primary"></span>
                                        <span class="label label--mini label__availability background-color--primary"></span>
                                        <span class="label label--mini label__availability background-color--primary"></span>
                                    </td>
                                    <td class="mdl-data-table__cell--non-numeric"><button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-teal">Add to cart</button></td>
                                </tr>
                                <tr>
                                    <td class="mdl-data-table__cell--non-numeric">6</td>
                                    <td class="mdl-data-table__cell--non-numeric">The secret Garden</td>
                                    <td class="mdl-data-table__cell--non-numeric">Frances Hodgson Burnett</td>
                                    <td class="mdl-data-table__cell--non-numeric"><span class="label label--mini color--orange">Childeren's literature</span> </td>
                                    <td class="mdl-data-table__cell--non-numeric">2017</td>
                                    <td class="mdl-data-table__cell--non-numeric">1911</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">
                                        <span class="label label--mini label__availability background-color--secondary"></span>
                                        <span class="label label--mini label__availability "></span>
                                        <span class="label label--mini label__availability "></span>
                                        <span class="label label--mini label__availability "></span>
                                    </td>
                                    <td class="mdl-data-table__cell--non-numeric"><button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-teal">Add to cart</button></td>
                                </tr>
                                <tr>
                                    <td class="mdl-data-table__cell--non-numeric">7</td>
                                    <td class="mdl-data-table__cell--non-numeric">Rebecca</td>
                                    <td class="mdl-data-table__cell--non-numeric">Daphne du Maurier</td>
                                    <td class="mdl-data-table__cell--non-numeric">
                                        <span class="label label--mini color--purple">Gothic fiction</span>
                                    </td>
                                    <td class="mdl-data-table__cell--non-numeric">2016</td>
                                    <td class="mdl-data-table__cell--non-numeric">1938</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">
                                        <span class="label label--mini label__availability color--orange"></span>
                                        <span class="label label--mini label__availability color--orange"></span>
                                        <span class="label label--mini label__availability"></span>
                                        <span class="label label--mini label__availability"></span>
                                    </td>
                                    <td class="mdl-data-table__cell--non-numeric"><button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-teal">Add to cart</button></td>
                                </tr>
                                <tr>
                                    <td class="mdl-data-table__cell--non-numeric">8</td>
                                    <td class="mdl-data-table__cell--non-numeric">Dracula</td>
                                    <td class="mdl-data-table__cell--non-numeric">Bram Stoker</td>
                                    <td class="mdl-data-table__cell--non-numeric">
                                        <span class="label label--mini color--purple">Gothic fiction</span>
                                        <span class="label label--mini color--dark-gray">Horror fiction</span>
                                    </td>
                                    <td class="mdl-data-table__cell--non-numeric">2015</td>
                                    <td class="mdl-data-table__cell--non-numeric">1897</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">English</td>
                                    <td class="mdl-data-table__cell--non-numeric">
                                        <span class="label label--mini label__availability"></span>
                                        <span class="label label--mini label__availability"></span>
                                        <span class="label label--mini label__availability"></span>
                                        <span class="label label--mini label__availability"></span>
                                    </td>
                                    <td class="mdl-data-table__cell--non-numeric"><button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-teal">Add to cart</button></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>
</asp:Content>
