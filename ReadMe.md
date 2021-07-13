@page "/readme"


<p align="center">

<h1>ReadMe</h1>
<br />
<h3 align="center">3D Test App</h3>
<p align="center">A Blazor Server app implimenting ADO.Net with SQL Server on a hosted Linux Ubuntu Build (Azure)</p>
<hr />
<h4 align="center">Dependencies</h4>
<ul>
  <li>Blazored.Modal" Version="6.0.1" </li>
    <li>Blazored.Toast" Version="3.1.2" </li>
    <li>System.Data.SqlClient" Version="4.8.2" </li>
    <li>Microsoft.Extensions.Caching.Memory" Version="5.0.0" </li>
    <li>Microsoft.Extensions.DependencyInjection" Version="5.0.2" </li>
    <li>Microsoft.Extensions.DependencyInjection.Abstractions" Version="5.0.0" </li>
    <li>Microsoft.Extensions.Options" Version="5.0.0" </li>
    <li>Microsoft.AspNetCore.Mvc.NewtonsoftJson" Version="5.0.8"</li>
    <li>Microsoft.AspNet.WebApi.Client" Version="5.2.7" </li>
</ul>
<hr />
<h4 align="center">Question Answers</h4>

<ul align="center">
    <li align="center"><strong>Now that you’ve seen the exercise, did you find the “prep” insights we sent in advance provided enough information to set you up to complete this exercise?</strong></li>
</ul>
<p>
    I found the insights very, well, insightful. I was able to add a few tools to my dev environment and do some much needed reading before I received the task.
</p>
<ul align="center">
    <li align="center"><strong>If you were the author, what additional information would you have provided?</strong></li>
</ul>
<p>
    Not much. I appreciated how open ended the task was as far as methodologies "suggested." The only thing that may have helped me out was a specified front end client as I
    wasted a bunch of time tyring to choose one, but then again, that was fun for me.
</p>
<ul align="center">
    <li align="center"><strong>As you considered your toolset, what did you choose and why? </strong></li>
</ul>
<p align="center">
    I stuck with the environments I know as far as IDEs were concerned. I did go off the deepend by choosing to deploy a linux SQL server on the cloud which took me quite some time as I've never used Azure or done a
    complete deployment of SQL server in the Shell, great learning experience. Similarly, I chose to make a .NetCore Blazor application for this project. I do so simply because I had never used the framework and I wanted
    a challenge and to learn to use it. I had meant to play with it for quite some time and this seemed like a perfect opportunity. All that being said, I probably added many additional hours to my workload but I don't count that a loss.
</p>
<ul align="center">
    <li align="center"><strong>Approximately how much time did it take to complete the coding part of the exercise? </strong></li>
</ul>
<p>
    I'd estimate the code itself took me around 5 hours, I find reading documentation (especailly with new technologies) eats up just as much time. Once again, I try to use
    all my efforts as learning experiences so I didn't mind the investment
</p>
<ul align="center">
    <li align="center"><strong>What part of this project took the most time? </strong></li>
</ul>
<p>
    Configuring my linux VM and SQL server build. I could have avoided all of that, but my linux proficiency was asked about during one of my interviews so I figured I'd kill two birds with one stone in that regard.
    It wasn't easy, but I got it done and I'm very happy that I now know I can do it again if/when needed.
</p>
<ul align="center">
    <li align="center"><strong>If you wanted to improve your application, what changes would you make, and/or what other features would you add?</strong></li>
</ul>
<p>
    I'd add many other features that I consider standard with production applications. For one, I have no user authentication built in. This was simply
    omitted because it wasn't called for in the specs, and by the time I got to the point where I had planned to impliment, time was becomming an issue.
    I also had planned on building out a full api with a swagger UI for simplified testing, but calling the api from inside the blazor application proved
    challanging enough to put me in a spot where I didn't think that was as important as building that out. I also would have added build scripts that
    could have included automation for building out the simple database table and stored procs I used in for dbmail when initially building the dotnet
    application, by the time I thought to do that it was no loger feasible. I also forgot to establish SC early in the process so I don't have as many commits
    up to github as I would normally like to have. Lastly, before I realized what I had done by using Blazor instead of Angular or React, I ran into a problem
    implimenting Javascript Validation on the form. I had to forgo that particular spec and use .net DataAnnotations and Blazor's validation logic to get that done,
    I should have considered this, I figured there was (and there is) a way inject Javascript code in the Razor components I used, but I lacked time to
    hash all that out on the fly.
</p>


<hr />
<p>

</p>
