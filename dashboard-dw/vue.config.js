const fs = require("fs");
const path = require("path");

const baseFolder =
  process.env.APPDATA !== undefined && process.env.APPDATA !== ""
    ? `${process.env.APPDATA}/ASP.NET/https`
    : `${process.env.HOME}/.aspnet/https`;

const certificateArg = process.argv
  .map((arg) => arg.match(/--name=(?<value>.+)/i))
  .filter(Boolean)[0];
const certificateName = certificateArg
  ? certificateArg.groups.value
  : "dashboard-dw";

if (!certificateName) {
  console.error(
    "Invalid certificate name. Run this script in the context of an npm/yarn script or pass --name=<<app>> explicitly."
  );
  process.exit(-1);
}

const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
const keyFilePath = path.join(baseFolder, `${certificateName}.key`);

module.exports = {
  transpileDependencies: true,
  productionSourceMap: false,
  filenameHashing: false,
  lintOnSave: true,
  runtimeCompiler: true,
  devServer: {
    https: {
      key: fs.readFileSync(keyFilePath),
      cert: fs.readFileSync(certFilePath),
    },
    proxy: "http://79.137.194.168:80/",
    // {
    //   "^/R4/GetR4Data": {
    //     target: "http://79.137.194.168:80/",
    //   },
    //   "^/AtrtittionYouth/GetAll": {
    //     target: "http://79.137.194.168:80/",
    //   },
    //   "^/Basic/GetSubjects": {
    //     target: "http://79.137.194.168:80/",
    //   },
    //   "^/R1/GetR1All": {
    //     target: "http://79.137.194.168:80/",
    //   },
    // },
    port: 5002,
  },
  css: {
    extract: false,
    sourceMap: false,
  },
  configureWebpack: {
    optimization: {
      splitChunks: false,
    },
    entry: {
      app: "./src/main.js",
    },
  },
};
