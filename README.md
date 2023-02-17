## Start your Local Backend Enviroment like this

1. Update WSL: - open Terminal
	         - wsl --update
Docker need this to run on windows, if you are using a UNIX based system,you don't need this.

2. Install Docker Desktop
		    - https://www.docker.com/products/docker-desktop/

3. Enable HyperV ( Hyper-Virtualization )
            - open powershell
	          - bcdedit /set hypervisorlaunchtype auto
            - Restart your computer
            
4. Compose up
            - Navigate to the project main folder
            - Open cmd ( make sure docker desktop is running in the background)
            - docker compose up
            
5. Let's see if it works.
            - Open your browser and navigate to localhost
