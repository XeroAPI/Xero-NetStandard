SCRIPT_DIR=$(dirname "$0")
PROJECT_ROOT=$(realpath "${SCRIPT_DIR}/..")
cd "${PROJECT_ROOT}"
dotnet format