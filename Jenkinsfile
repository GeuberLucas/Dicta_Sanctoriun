pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                git branch: 'master', url: 'https://github.com/GeuberLucas/Dicta_Sanctoriun.git'
            }
        }
        stage('Build') {
            steps {
                
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
                echo 'testing angular app'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
                echo 'Deployed....'
            }
        }
    }
}
