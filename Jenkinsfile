
pipeline {
    agent any
    node {
        stage('Build') {
            steps {
                echo 'Building.. node 1'
            }
        }
    }
    node {
        stages {
            stage('Build 2') {
                steps {
                    echo 'Building.. node 2 '
                }
            }
            stage('Test') {
                steps {
                    echo 'Testing..'
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
}
