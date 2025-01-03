pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                    bat 'dotnet build'
                    bat 'npm run buildprod --prefix Dicta-Sanctorum-Front'
            }
        }
        stage('Test') {
            steps {
                bat 'dotnet test'
                bat 'npm install --prefix Dicta-Sanctorum-Front'
                bat 'npm run test --prefix Dicta-Sanctorum-Front'
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
