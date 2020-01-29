## Version Control Systems
- Version Control System to keep track of all the changes
- Types
    - Centralised : SVN, TFS
    - Distributed : Git
    
- bash commands:
   - `cd <dir>`
        change directory, can be absolute (like "/c/revature")
        or relative (like "my-project" in the current folder)
   - `ls <dir>`
        list contents of a directory
        (or the current directory, by default)
   - `mkdir <dir>`
        create a directory
   - `rm <path>`
        delete a file
   - `rm -r <path>`
        delete a directory
   - `mv <path1> <path2>`
        rename/move a file/directory
## GIT
3 places in git 
- Working Directory
- Staging Area
- .git Directory/Repo

### Basic git commands 
    - `git config --global user.name '<username>'`
            sets the author name globally
    - `git config --global user.email '<email>'`
            sets the email globally
    - `git help <verb>`
            get help text from the html in git 
    - `git <verb> --help`
          opens help html on the browser 
    - `git <verb> -h`
             gives you list of help options in CMD
    - `git init`
         initializes the git and have all the tracking information
    - `git status`
         tracks all the changes made, this will ignore the files mentioned in gitignore
    - `git clone`
            download a local copy of a repository,
            with all the history of past versions.
    - `git status`
        report on state of local repository, including any
        untracked files, unpushed commits, etc.
    - `git diff`
            gives difference made in the code
    - git add
        stage changes to be committed.
        use "."/ "-A" to stage all changes in the currect directory.
    - git reset <file to be unstaged>
    - git reset 
        will reset all files
    - git commit
        record a permanent commit of changes to the local
        repository.
        use "-m" to add a commit message in-line. launches nano otherwise.
    - git log 
            info about the commit author and commit message
    - git push
        upload all new commits to the remote (GitHub).
        will fail if there are already un-pulled commits there.
        will fail if you lack permissions.
    - git pull
            update your local repository with all new commits
            from the remote (GitHub).
            will fail if any local changes conflict.
    - Get out of git
            Ctrl+X: quit
                     (Y, enter to save unsaved changes)

### Git Remote commands 
    - git remote -v
        gives the remote version of the branch
    - git branch -a
        lists all the branches
    - git branch <feature branch name>
        creates a new branch copying the contents of master
    - git checkout <branch name/feature branch>
        takes you out of master and points its to working branch
        let you work on the featured branch mentioned
        you can use git status, git add, git commit in this branch
    - git push -u origin <feature branch>
        lets you push to the feature branch with upstream (means that feature branch and origin 
        are associated)
        if you use git branch -a will list you all the branch with * pointing to the current branch
    - git checkout master
        to change the pointer/head to master
        sometimes the work in feature branch has changes to commit and it will give error to checkout to master in this case either commit and push those changes or use `git stash save <filename>
        use git branch -a to check the pointer if its pointing to master
        also make sure to make a git pull origin master to get any changes made by a team  memeber in the master
    - git branch --merged    
        to see what feature branches have been merged to master        
    - git merge <feature branch name>    
        merges changes from the feature branch to master 
    - git push origin master 
        will make final changes to the master    
        use git branch --merged to check what branch has been merged to master 
    - git branch -d <feature branch name>
        deletes the feature branch from the working directory
        but if you use `git branch -a` it will show that there is <feature branch in > in origin
    - git push origin --delete <feature branch name>
        this will delete the vranch from the origin
        test it using the git branch -a
    
    