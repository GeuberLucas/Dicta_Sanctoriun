pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                    bat 'dotnet build'
                    bat 'cd Dicta-Sanctorum-Front'
                    dir('Dicta-Sanctorum-Front') {
                        bat 'npm install'
                        bat 'npm run buildprod'
                    }
                    
            }
        }
        stage('Test') {
            steps {
                bat 'dotnet test'
                bat 'cd Dicta-Sanctorum-Front'
                bat 'npm run test --prefix Dicta-Sanctorum-Front'
                bat 'cd ..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
    post {
        // Clean after build
        always {
            cleanWs(cleanWhenNotBuilt: false,
                    deleteDirs: true,
                    disableDeferredWipeout: true,
                    notFailBuild: true,
                    patterns: [[pattern: '.gitignore', type: 'INCLUDE'],
                               [pattern: '.propsfile', type: 'EXCLUDE']])
        }
    }
}
