/// <binding AfterBuild='sassconvert' />
var gulp = require('gulp');
var sass = require('gulp-sass');
var concat = require("gulp-concat");
var cssmin = require("gulp-cssmin");

gulp.task("Test", function () {
    console.log("Check");
})
//gulp.task("sassconvert", function () {
//    return gulp.src("wwwroot/styles/StyleSheet.scss").pipe(sass()).pipe(gulp.dest("wwwroot/css"))
//})
var path = {
    webroot: "wwwroot/"
};  
path.MyFile = path.webroot + "css/StyleSheet.css";
path.myCssMinFileName = "StyleSheet.min.css";
path.destinationFolder = path.webroot + "mins";
gulp.task("minify", function () {
    return gulp.src(path.MyFile)
        .pipe(concat(path.myCssMinFileName))
        .pipe(cssmin())
        .pipe(gulp.dest(path.destinationFolder));
})