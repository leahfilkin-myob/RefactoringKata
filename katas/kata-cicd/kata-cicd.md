# CI/CD Kata

The focus of the CI/CD kata is to bring safety when bringing things into production. You job is to make a reliable pipeline that can deploy your system into production. This kata is broken up into two steps, part 1 focusses around continuous integration, part 2 focuses on continuous deployment. 

This kata assumes you have a web application code base with a set of tests that you can already use to do CI/CD. We would recommend you first complete something like [Frameworkless Basic Web Application kata](https://github.com/MYOB-Technology/General_Developer/blob/master/katas/kata-frameworkless-basic-web-application/kata-frameworkless-basic-web-application.md) with the [enhancements](https://github.com/MYOB-Technology/General_Developer/blob/master/katas/kata-frameworkless-basic-web-application/kata-frameworkless-basic-web-application-enhancements.md).

## Continuous Integration 

* Your pipeline needs to be automated (no manual steps)
* No passwords or sensitive data should be stored in version control.  
* Automation and pipeline scripts should be in version control and treated as first class citizens
* On check to your version control repository, your test suit should run

## Continuous Deployment

Now that you have continuous integration working, it's time to implement continuous deployment. 

* Your deployment pipeline needs to be automated (no manual steps)
* If after check in your tests pass the system should be deployed to production
* If after check in one or more of your tests fail the system should **not** be deployed to production
