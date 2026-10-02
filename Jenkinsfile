pipeline {

    agent any

    stages {

        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Unit Test') {
            steps {
                bat 'dotnet test --configuration Release --no-build'
            }
        }

        stage('Publish') {
            steps {
                bat 'dotnet publish --configuration Release --output Publish --no-build'
            }
        }

        stage('Create Artifact') {
            steps {
                bat 'powershell -Command "Compress-Archive -Path Publish\\* -DestinationPath CustomerAPI.zip -Force"'
            }
        }

    }

}

