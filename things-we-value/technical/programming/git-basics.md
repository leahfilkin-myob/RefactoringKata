# Git basics

At MYOB we predominantly use Git & GitHub for version control. Knowing how to use Git will be key to most crews you join.

## Background

### Centralized vs. Distributed Version Control

Version control is a system for managing changes to the source of a project. This allows easier collaboration, tracking, and documentation on a project. 

Version Control Systems (VCS) can take two main forms: Centralized, and Distributed. 

Centralized systems maintain the history of the project in one, central, place. This is the Single Source of Truth for the project. People send their updates to the central source to make changes to the project. Examples of Centralized VCSs: Subversion, Perforce.

In Distributed systems, each person has a copy of the entire history of the project on their local machine. The Single Source of Truth is an agreed location, rather than enforced by the tool. To make updates to the project, a person "pushes" their version of history to the agreed location. Other people can then "pull" any changes to their local machine.

### What is git?

Git is a distributed version control system. It was created by Linus Torvalds in 2005 to manage the development of the Linux kernel. Several Software as a Service providers such as GitHub, BitBucket, and GitLab support git as a VCS. Due to its distributed nature, git allows a developer to track changes locally while working offline. These changes can then be pushed to a remote repository where other developers collaborating on the same project can view them.

## Where do I start with git?

So I have logged into GitHub and created a new repository. What's next?

I would need the repository on my local machine so I would `clone` the repository, start working on the project, `add` files to be tracked and `commit` the changes. When collaborating with other developers, I would also need to `push` my changes to the remote repository so other developers can `pull` my changes.

Tower has a good [git workflow infographic](https://www.git-tower.com/blog/workflow-of-git/).

## Common Git and GitHub Concepts

### Branching

Git maintains history using [Graph theory](https://en.wikipedia.org/wiki/Graph_theory). In the beginning, there is a single line of development, known as "master". This line is used as the source of truth for the repository. A common pattern is to create a "branch" off of this line, allowing multiple concurrent lines of development.

### Merging

At some point a branch needs to be recombined with the original line of development to become part of the source of truth. This is known as "merging".

### Pull Requests

Git and GitHub are great tools for collaborating on a project. One way to collaborate, is to create a "Pull request". This is a request to merge a branch into another branch (they can be in the same repository, or different repositories). This process allows someone else to review and provide feedback on the changes before merging.

## Resources

[GitHub Guides](https://guides.github.com/) - tutorials from GitHub on using git and GitHub  
[Git Branching Game](http://pcottle.github.io/learnGitBranching/) - game for learning git branching and navigation  
[Git Exercises](https://gitexercises.fracz.com/) - learn and practice git, discover features  
[Try Git Course](https://www.codeschool.com/courses/try-git)  
[Git Real Course]( https://www.codeschool.com/courses/git-real)  
[Mastering GitHub Course](https://www.codeschool.com/courses/mastering-github)  
[Git Cheatsheet](https://ndpsoftware.com/git-cheatsheet.html)
