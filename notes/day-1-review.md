# Day 1 Review

Please address your current understanding of the following topics we covered (or began to cover) in class today. Your thoughts about these can and should be revised throughout the training (and your career!) as your understanding grows.

I am *not* looking for super "technical" stuff here. Just your ability to express and convey in your way your understanding of these things.

## 1. Git

We created a git repository on our VMs and added some existing code and committed it. We then used the `gh` cli tool to push that code to Github. 

- Say a few words about why *we* are using source control in this class?

To reduce conflict, maintain code and history, QA. 

- Say a few words about how source control is used by teams of developers working on the same code base.
1. There is a master branch, which holds the "approved" code from all developers
2. All developers, when working on their assigned work, will create branches to ensure that they are not conflicting work with other developers.
3. Once a developer's work is done (add, commit, push), they'll create a pull request to merge to the master branch.
4. A PR is for a other developers to code review the work, and approve the merge to master. 
- What is meant when we say a copy of the repository is the "origin"? (That's our copy on github).

A remote repository in which a local copy is cloned. Origin, or sometimes Master or Main, is the default name. 

- Why do we create commits locally?

To save/track our work that we've done since the previous commit.

- Why do we push those commits to Github?

To update our main repository with the work that we've committed locally.


### Extra Credit

What were the steps, as detailed as you like, that we took to create our repository and push it to Github.

1. git config our credentials
2. git init the repo
3. git add . (or specify the specific files you want to stage)
4. git commit -m "message here"
5. gh something (I forgot sorry D:)

What are some other ways you might do the same thing?
- You can do git push origin branch-name instead of gh command
- You can also do this through VS code or Visual Studio's own git tools instead of CLI


## 2. Services

We began a project in Visual Studio to create a service. What is meant by the term "Service" in software development?
- A thingy (in our case, a program that consists of written code) that does some stuff.

Our service exposes an *interface* that other applications can use to drive our service (make it do stuff). This is an
"Application Programming Interfact". How does an API differ from a "User Interface" (UI)? How are they similiar?

- An API is used to devs or other applications, in which it allows systems to communicate with each other by sending requests and receiving responses. A UI is designed for the end-user (customer/client), who interacts with the software that calls the API.

What are some benefits of exposing a service's interface using the HTTP Protocol?

1. Relatively easy to secure
2. Supports standards-based caching
3. Reach or "ease" of entry (many languages has tools or frameworks to be able to create HTTP requests and responses)
4. Known to developers and clients

We "tested" our API three different ways. 

1. Manually using SwaggerUI
2. Manually using the `.http` file functionality in Visual Studio
3. Automated using an xUnit test project.

Which is the *right* way to do it? Why give preference to automated tests? 

Automated should the developer's choice or process when writing code, but all code should be manually tested as well (maybe by different team in the development cycle)

### Extra Credit

Have you used any existing HTTP APIs in other projects?

Yes. I've used Spotify API and Youtube Data API for previous personal projects.

Have you created any other HTTP APIs in your own work or studies?

No
