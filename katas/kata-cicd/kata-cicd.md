# CI/CD with Containers Kata

The focus of the CI/CD with Containers kata is to bring safety when bringing things into production. You job is to make a reliable pipeline that can deploy your system into production. You are going to use containers as a tool to do this. This kata is broken up into three parts, part 1 focusses around getting a container to run on your local machine. Part 2 focusses around continuous integration, Part 3 focuses on continuous deployment. 

This kata assumes you already have a web application code base with automated tests that you use to do CI/CD (we recommend you first complete something like [Frameworkless Basic Web Application kata](https://github.com/MYOB-Technology/General_Developer/blob/master/katas/kata-frameworkless-basic-web-application/kata-frameworkless-basic-web-application.md) with the [enhancements](https://github.com/MYOB-Technology/General_Developer/blob/master/katas/kata-frameworkless-basic-web-application/kata-frameworkless-basic-web-application-enhancements.md)).

## Containerization

* You need to set up a container that your system can be built and run in

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
