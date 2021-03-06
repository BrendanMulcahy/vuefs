# F# ASP.NET Core 2.0 + Vue.js
An F# ASP.NET Core 2.0 SPA Sample Project with Vue.js and Webpack

### Requirements

* [Node.js](https://nodejs.org/en/)
  * To test this is installed and can be found, run `node -v` on a command line
* [.NET Core](https://dot.net), version 2.0 or later

### Getting Started
Open a command window at the root of the project and run the following:

1. `dotnet restore`
2. `npm install`
3. `node node_modules/webpack/bin/webpack.js --config webpack.config.vendor.js`
4. `node node_modules/webpack/bin/webpack.js --config webpack.config.js`

At this point, you should be able to build/run the project in VS2017.  You might get a few typescript errors but these can be ignored.