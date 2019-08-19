# OptimumLocation

Aims to solve the problem of where to live.

Too many people live in a sub optimal commute location for them and their partner / family. This repo aims to build a website and WPF tool which allows
users to find their opitimum commutepoint based on a specified list of locations and commute frequency.

The project consists of a database with web API and two separate UI's.

There is a SPA (Single page application) which provides all the functionality once a user is logged in but there is also a landing page and login system 
which are the places the user first visits when they reach pro.optimumlocation.com. 

The main optimum location domain is just a static page with a trial site and no login, this gives users a taste of what they can do but does not allow them to 
save any data.

# Pro website flow

- Landing page (A splash page with a login / register link)
- Registration page (where user enters name and password) (modeled off netflix login)
- Payments page (where user must pay by debit / credit card/ btc)
- App page (where you can create, save, edit and delete 'commutes' and your home location)
