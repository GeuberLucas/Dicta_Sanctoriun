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
                    bat 'dotnet build'
                    bat 'npm run buildprod --prefix Dicta-Sanctorum-Front'
            
            }
        }
        stage('Test') {
            steps {
                
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
