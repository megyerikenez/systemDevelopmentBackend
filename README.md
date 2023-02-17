## Start your Local Backend Enviroment like this

 ### 1. Update WSL: 
	 open Terminal
	 wsl --update
	 Docker need this to run on windows, if you are using a UNIX based system,you don't need this.

 ### 2. Install Docker Desktop
	https://www.docker.com/products/docker-desktop/

### 3. Enable HyperV ( Hyper-Virtualization 
            open powershell
	    bcdedit /set hypervisorlaunchtype auto
            Restart your computer
            
### 4. Let's spin up Docker
            Navigate to the project main folder
            Open cmd ( make sure docker desktop is running in the background)
            docker compose up
            
### 5. Let's see if it works.
            Open your browser and navigate to localhost
            You should see something like this : ["Blog post #0","Blog post #1","Blog post #2","Blog post #3","Blog post #4"]

### 6. How to Stop and Start the Enviroment
            If you had enough coding for the day just go to the project folder and use "docker compose stop".
            If you had enough coffee to comeback for a code session use "docker compose start".

### HELP
	    Don't use "docker compose down". It will remove the docker context which means its a fucking nuke :) You will lose every data in cache and in the database.
