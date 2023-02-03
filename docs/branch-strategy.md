# Branch strategy
> Recomendations based on [Microsoft General Naming Conventions](https://learn.microsoft.com/en-us/azure/devops/repos/git/git-branching-guidance?view=azure-devops)

Our your strategy is based on these three concepts:

- Use feature branches for all new features and bug fixes.
- Merge feature branches into the main branch using pull requests.
- Keep a high quality, up-to-date main branch.

## Use feature branches for your work

Develop your features and fix bugs in feature branches based off your main branch. These branches are also known as topic branches. Feature branches isolate work in progress from the completed work in the main branch. Git branches are inexpensive to create and maintain. Even small fixes and changes should have their own feature branch.

![Feature Branching](./featurebranching.png)

Creating feature branches for all your changes makes reviewing history simple. Look at the commits made in the branch and look at the pull request that merged the branch.

## Name branch convention

Use a prefix according to the issue purpose.

- feature/[#-issue]-feature-name
- hotfix/[#-issue]-description
- bugfix/[#-issue]-description