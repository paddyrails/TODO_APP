pipeline {
  agent any

  stages {
    stage("Clean Up"){
      steps {
        deleteDir()
      }
    }
     stage("Clone Repo"){
      steps {
        sh "git clone https://github.com/paddyrails/TODO_APP.git"
      }
    }
    stage("Build"){
      steps {
        dir("TODO_APP"){
          echo "Running build.."    
          echo "Running tests.."    
        }
      }
    }
    stage("Create docker image and publish"){
      steps {
        dir("TODO_APP"){
          echo "Running build.."    
          sh "docker build -t paddypillai/todo_app:${BUILD_NUMBER} ."
          sh "docker push paddypillai/todo_app:${BUILD_NUMBER}-release"
        }
      }
    }
  }
}
