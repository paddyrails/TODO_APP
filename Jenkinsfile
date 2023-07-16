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
        echo "Cloning repo"
        // sh "git clone https://github.com/paddyrails/TODO_APP.git"
      }
    }
    stage("Compile & Test"){
      steps {
        dir("TODO_APP"){
          echo "Running build.."    
          echo "Running tests.."    
        }
      }
    }
    stage("Update Sonar Report"){
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
          // sh "docker build -t paddypillai/todo_app:${BUILD_NUMBER} ."
          // sh "docker push paddypillai/todo_app:${BUILD_NUMBER}-release"
        }
      }
    }
    stage("Deploy code to live Prod and DR"){
      steps {
        dir("TODO_APP"){
          echo "Deploying to Live Prod and DR.."              
        }
      }
    }
  }
}
